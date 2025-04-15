//using Moq;
//using OnlineLearning.Models.Domains.CourseModels.LessonModels;
//using OnlineLearning.Repositories.Interfaces;
//using OnlineLearning.Services.Implementations;
//using System;
//using System.Threading.Tasks;
//using Xunit;

//namespace OnlineLearning.Tests.Services
//{
//    public class DiscussionLessonServiceTests
//    {
//        private readonly Mock<IDiscussionLessonRepository> _mockDiscussionLessonRepository;
//        private readonly DiscussionLessonService _discussionLessonService;

//        public DiscussionLessonServiceTests()
//        {
//            _mockDiscussionLessonRepository = new Mock<IDiscussionLessonRepository>();
//            _discussionLessonService = new DiscussionLessonService(_mockDiscussionLessonRepository.Object);
//        }

//        [Fact]
//        public async Task AddDiscussionLessonAsync_ValidInput_CallsRepositoryAdd()
//        {
//            // Arrange
//            var discussionLesson = new DiscussionLesson
//            {
//                Comment = "This is a valid comment",
//                LessonId = 1,
//                UserId = 1,
//                CreatedAt = DateTime.Now,
//                ParentCommentID = null
//            };

//            _mockDiscussionLessonRepository.Setup(r => r.AddDiscussionLessonAsync(It.IsAny<DiscussionLesson>())).Returns(Task.CompletedTask);

//            // Act
//            await _discussionLessonService.AddDiscussionLessonAsync(discussionLesson);

//            // Assert
//            _mockDiscussionLessonRepository.Verify(r => r.AddDiscussionLessonAsync(It.Is<DiscussionLesson>(
//                d => d.Comment == discussionLesson.Comment &&
//                     d.LessonId == discussionLesson.LessonId &&
//                     d.UserId == discussionLesson.UserId &&
//                     d.ParentCommentID == discussionLesson.ParentCommentID)), Times.Once());
//        }

//        [Fact]
//        public async Task AddDiscussionLessonAsync_NullComment_ThrowsArgumentException()
//        {
//            // Arrange
//            var discussionLesson = new DiscussionLesson
//            {
//                Comment = null, // Comment null
//                LessonId = 1,
//                UserId = 1,
//                CreatedAt = DateTime.Now,
//                ParentCommentID = null
//            };

//            // Giả định service có validation ném ngoại lệ nếu comment null
//            _mockDiscussionLessonRepository.Setup(r => r.AddDiscussionLessonAsync(It.IsAny<DiscussionLesson>())).Returns(Task.CompletedTask);

//            // Act & Assert
//            await Assert.ThrowsAsync<ArgumentException>(() => _discussionLessonService.AddDiscussionLessonAsync(discussionLesson));
//        }

//        [Fact]
//        public async Task AddDiscussionLessonAsync_RepositoryThrowsException_PropagatesException()
//        {
//            // Arrange
//            var discussionLesson = new DiscussionLesson
//            {
//                Comment = "This is a valid comment",
//                LessonId = 1,
//                UserId = 1,
//                CreatedAt = DateTime.Now,
//                ParentCommentID = null
//            };

//            _mockDiscussionLessonRepository.Setup(r => r.AddDiscussionLessonAsync(It.IsAny<DiscussionLesson>())).ThrowsAsync(new Exception("Database error"));

//            // Act & Assert
//            var exception = await Assert.ThrowsAsync<Exception>(() => _discussionLessonService.AddDiscussionLessonAsync(discussionLesson));
//            Assert.Equal("Database error", exception.Message);
//        }
//    }
//}