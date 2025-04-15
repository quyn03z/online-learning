using Microsoft.AspNetCore.Http;
using Moq;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Implementations;
using Xunit;
using System.IO;
using System.Threading.Tasks;
using OnlineLearning.Models.Domains.UserModels;

namespace OnlineLearning.Tests.Services
{
	public class UserServiceTests
	{
		private readonly Mock<IUserRepository> _mockUserRepository;
		private readonly Mock<IUserRoleRepository> _mockUserRoleRepository;
		private readonly UserService _userService;

		public UserServiceTests()
		{
			_mockUserRepository = new Mock<IUserRepository>();
			_mockUserRoleRepository = new Mock<IUserRoleRepository>();
			_userService = new UserService(_mockUserRepository.Object, _mockUserRoleRepository.Object);
		}

		[Fact]
		public async Task ChangeAvatarAsync_ValidFile_ReturnsTrue()
		{
			// Arrange
			long userId = 1;
			var mockFile = new Mock<IFormFile>();
			var fileName = "test.jpg";
			var filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
			var fileStream = new FileStream(filePath, FileMode.Create);
			mockFile.Setup(f => f.FileName).Returns(fileName);
			mockFile.Setup(f => f.Length).Returns(500 * 1024); // 500 KB
			mockFile.Setup(f => f.CopyToAsync(It.IsAny<Stream>(), default)).Returns(Task.CompletedTask);

			_mockUserRepository.Setup(r => r.UpdateAvatarAsync(userId, It.IsAny<string>())).ReturnsAsync(true);

			// Act
			var result = await _userService.ChangeAvatarAsync(userId, mockFile.Object);

			// Assert
			Assert.True(result);
			_mockUserRepository.Verify(r => r.UpdateAvatarAsync(userId, It.IsAny<string>()), Times.Once);
		}

		[Fact]
		public async Task ChangeAvatarAsync_NullFile_ReturnsFalse()
		{
			// Act
			var result = await _userService.ChangeAvatarAsync(1, null);

			// Assert
			Assert.False(result);
			_mockUserRepository.Verify(r => r.UpdateAvatarAsync(It.IsAny<long>(), It.IsAny<string>()), Times.Never);
		}

		[Fact]
		public async Task ChangeAvatarAsync_EmptyFile_ReturnsFalse()
		{
			// Arrange
			var mockFile = new Mock<IFormFile>();
			mockFile.Setup(f => f.Length).Returns(0); // Empty file

			// Act
			var result = await _userService.ChangeAvatarAsync(1, mockFile.Object);

			// Assert
			Assert.False(result);
			_mockUserRepository.Verify(r => r.UpdateAvatarAsync(It.IsAny<long>(), It.IsAny<string>()), Times.Never);
		}

		[Fact]
		public async Task ChangeAvatarAsync_FileTooLarge_ReturnsFalse()
		{
			// Arrange
			var mockFile = new Mock<IFormFile>();
			mockFile.Setup(f => f.Length).Returns(900 * 1024); // 900 KB, larger than 800 KB

			// Act
			var result = await _userService.ChangeAvatarAsync(1, mockFile.Object);

			// Assert
			Assert.False(result);
			_mockUserRepository.Verify(r => r.UpdateAvatarAsync(It.IsAny<long>(), It.IsAny<string>()), Times.Never);
		}

		[Fact]
		public async Task ChangeAvatarAsync_InvalidFileExtension_ReturnsFalse()
		{
			// Arrange
			var mockFile = new Mock<IFormFile>();
			mockFile.Setup(f => f.FileName).Returns("test.txt"); // Invalid extension
			mockFile.Setup(f => f.Length).Returns(500 * 1024); // 500 KB

			// Act
			var result = await _userService.ChangeAvatarAsync(1, mockFile.Object);

			// Assert
			Assert.False(result);
			_mockUserRepository.Verify(r => r.UpdateAvatarAsync(It.IsAny<long>(), It.IsAny<string>()), Times.Never);
		}

		[Fact]
		public async Task ChangePasswordAsync_ValidUserId_ChangesPasswordSuccessfully()
		{
			// Arrange
			long userId = 1;
			var changePassDTO = new ChangePassDTO { NewPassword = "NewPassword123" };
			var user = new User { UserId = userId, Password = "OldPassword123" };

			_mockUserRepository.Setup(r => r.GetByIdAsync(userId)).ReturnsAsync(user);
			_mockUserRepository.Setup(r => r.UpdateAsync(user)).Returns(Task.CompletedTask);

			// Act
			var result = await _userService.ChangePasswordAsync(userId, changePassDTO);

			// Assert
			Assert.True(result);
			Assert.NotEqual("OldPassword123", user.Password); // Ensure password has changed
			_mockUserRepository.Verify(r => r.UpdateAsync(user), Times.Once);
		}

		[Fact]
		public async Task ChangePasswordAsync_InvalidUserId_ReturnsFalse()
		{
			// Arrange
			long userId = 1;
			var changePassDTO = new ChangePassDTO { NewPassword = "NewPassword123" };

			_mockUserRepository.Setup(r => r.GetByIdAsync(userId)).ReturnsAsync((User)null); // User not found

			// Act
			var result = await _userService.ChangePasswordAsync(userId, changePassDTO);

			// Assert
			Assert.False(result);
			_mockUserRepository.Verify(r => r.UpdateAsync(It.IsAny<User>()), Times.Never);
		}

		[Fact]
		public async Task UpdateProfileAsync_ValidProfile_ReturnsTrue()
		{
			// Arrange
			var profile = new ProfileDTO { UserId = 1, FullName = "John Doe", Email = "john.doe@example.com" };

			_mockUserRepository.Setup(r => r.UpdateUserInfoAsync(profile)).ReturnsAsync(true);

			// Act
			var result = await _userService.UpdateProfileAsync(profile);

			// Assert
			Assert.True(result);
			_mockUserRepository.Verify(r => r.UpdateUserInfoAsync(profile), Times.Once);
		}

		[Fact]
		public async Task UpdateProfileAsync_InvalidProfile_ReturnsFalse()
		{
			// Arrange
			ProfileDTO profile = null; // Simulate an invalid profile

			// Act
			var result = await _userService.UpdateProfileAsync(profile);

			// Assert
			Assert.False(result);
			_mockUserRepository.Verify(r => r.UpdateUserInfoAsync(It.IsAny<ProfileDTO>()), Times.Never);
		}
	}
}