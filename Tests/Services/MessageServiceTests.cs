using Moq;
using OnlineLearning.Models.Domains.Miscellaneous;
using OnlineLearning.Models.Domains.UserModels;
using OnlineLearning.Models.DTOs;
using OnlineLearning.Repositories.Interfaces;
using OnlineLearning.Services.Implementations;
using Xunit;

namespace OnlineLearning.Tests.Services
{
    public class MessageServiceTests
    {
        private readonly Mock<IMessageRepository> _messageRepositoryMock;
        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly MessageService _messageService;

        public MessageServiceTests()
        {
            _messageRepositoryMock = new Mock<IMessageRepository>();
            _userRepositoryMock = new Mock<IUserRepository>();
            _messageService = new MessageService(_messageRepositoryMock.Object, _userRepositoryMock.Object);
        }

        [Fact]
        public async Task SendMessageAsync_ShouldCreateAndReturnMessage()
        {
            // Arrange
            long senderId = 1;
            long receiverId = 2;
            string content = "Test message";

            var expectedMessage = new Message
            {
                MessageId = 1,
                SenderId = senderId,
                ReceiverId = receiverId,
                Content = content,
                IsRead = false
            };

            _messageRepositoryMock.Setup(repo => repo.AddMessageAsync(It.IsAny<Message>()))
                .ReturnsAsync((Message message) => 
                {
                    message.MessageId = 1;
                    return message;
                });

            // Act
            var result = await _messageService.SendMessageAsync(senderId, receiverId, content);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(senderId, result.SenderId);
            Assert.Equal(receiverId, result.ReceiverId);
            Assert.Equal(content, result.Content);
            Assert.False(result.IsRead);
            _messageRepositoryMock.Verify(repo => repo.AddMessageAsync(It.IsAny<Message>()), Times.Once);
        }

        [Fact]
        public async Task GetMessagesBetweenUsersAsync_ShouldReturnMessages()
        {
            // Arrange
            long senderId = 1;
            long receiverId = 2;
            var expectedMessages = new List<Message>
            {
                new Message { MessageId = 1, SenderId = senderId, ReceiverId = receiverId, Content = "Hello" },
                new Message { MessageId = 2, SenderId = receiverId, ReceiverId = senderId, Content = "Hi there" }
            };

            _messageRepositoryMock.Setup(repo => repo.GetMessagesBetweenUsersAsync(senderId, receiverId))
                .ReturnsAsync(expectedMessages);

            // Act
            var result = await _messageService.GetMessagesBetweenUsersAsync(senderId, receiverId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            _messageRepositoryMock.Verify(repo => repo.GetMessagesBetweenUsersAsync(senderId, receiverId), Times.Once);
        }

        [Fact]
        public async Task GetChatPartnersAsync_ShouldReturnChatPartners()
        {
            // Arrange
            long userId = 1;
            long partnerId1 = 2;
            long partnerId2 = 3;

            var latestMessages = new List<Message>
            {
                new Message { MessageId = 1, SenderId = userId, ReceiverId = partnerId1, Content = "Hello", CreatedAt = DateTime.Now.AddMinutes(-10) },
                new Message { MessageId = 2, SenderId = partnerId2, ReceiverId = userId, Content = "Hi there", CreatedAt = DateTime.Now.AddMinutes(-5) }
            };

            var partner1 = new User { UserId = partnerId1, FullName = "User2" };
            var partner2 = new User { UserId = partnerId2, FullName = "User3" };

            _messageRepositoryMock.Setup(repo => repo.GetLatestMessagesForUserAsync(userId))
                .ReturnsAsync(latestMessages);

            _userRepositoryMock.Setup(repo => repo.GetByIdAsync(partnerId1))
                .ReturnsAsync(partner1);
            _userRepositoryMock.Setup(repo => repo.GetByIdAsync(partnerId2))
                .ReturnsAsync(partner2);

            _messageRepositoryMock.Setup(repo => repo.CountUnreadMessagesAsync(partnerId1, userId))
                .ReturnsAsync(0);
            _messageRepositoryMock.Setup(repo => repo.CountUnreadMessagesAsync(partnerId2, userId))
                .ReturnsAsync(1);

            // Act
            var result = await _messageService.GetChatPartnersAsync(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            
            var resultList = result.ToList();
            Assert.Equal(partner1.UserId, resultList[0].Partner.UserId);
            Assert.Equal(partner2.UserId, resultList[1].Partner.UserId);
            Assert.Equal(0, resultList[0].UnreadCount);
            Assert.Equal(1, resultList[1].UnreadCount);
            
            _messageRepositoryMock.Verify(repo => repo.GetLatestMessagesForUserAsync(userId), Times.Once);
            _userRepositoryMock.Verify(repo => repo.GetByIdAsync(partnerId1), Times.Once);
            _userRepositoryMock.Verify(repo => repo.GetByIdAsync(partnerId2), Times.Once);
        }

        [Fact]
        public async Task GetChatPartnersAsync_ShouldSkipNullPartners()
        {
            // Arrange
            long userId = 1;
            long partnerId1 = 2;
            long partnerId2 = 3; // Sẽ trả về null

            var latestMessages = new List<Message>
            {
                new Message { MessageId = 1, SenderId = userId, ReceiverId = partnerId1, Content = "Hello" },
                new Message { MessageId = 2, SenderId = partnerId2, ReceiverId = userId, Content = "Hi there" }
            };

            var partner1 = new User { UserId = partnerId1, FullName = "User2" };

            _messageRepositoryMock.Setup(repo => repo.GetLatestMessagesForUserAsync(userId))
                .ReturnsAsync(latestMessages);

            _userRepositoryMock.Setup(repo => repo.GetByIdAsync(partnerId1))
                .ReturnsAsync(partner1);
            _userRepositoryMock.Setup(repo => repo.GetByIdAsync(partnerId2))
                .ReturnsAsync((User)null);

            _messageRepositoryMock.Setup(repo => repo.CountUnreadMessagesAsync(partnerId1, userId))
                .ReturnsAsync(0);

            // Act
            var result = await _messageService.GetChatPartnersAsync(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal(partner1.UserId, result.First().Partner.UserId);
        }

        [Fact]
        public async Task MarkMessagesAsReadAsync_ShouldCallRepository()
        {
            // Arrange
            long senderId = 1;
            long receiverId = 2;

            // Act
            await _messageService.MarkMessagesAsReadAsync(senderId, receiverId);

            // Assert
            _messageRepositoryMock.Verify(repo => repo.MarkMessagesAsReadAsync(senderId, receiverId), Times.Once);
        }
    }
}
