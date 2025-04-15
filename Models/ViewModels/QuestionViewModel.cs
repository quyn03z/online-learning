using OnlineLearning.Models.DTOs;

namespace OnlineLearning.Models.ViewModels
{
    public class QuestionViewModel
    {
        public int ModuleNumber { get; set; }
        public string ModuleName { get; set; }
        public long CourseId { get; set; }
        public QuizDTO Quiz { get; set; }
        public QuestionsDTO Question { get; set; }
        public List<OptionsDTO> Options { get; set; }
        public List<QuestionWithOptionsDTO> Questions { get; set; } = new List<QuestionWithOptionsDTO>();
    }
}
