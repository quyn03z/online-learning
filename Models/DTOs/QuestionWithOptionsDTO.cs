using OnlineLearning.Enums;

namespace OnlineLearning.Models.DTOs
{
    public class QuestionWithOptionsDTO
    {
        public long QuestionId { get; set; }
        public long QuizId { get; set; }
        public string QuestionName { get; set; } = null!;
        public QuestionType Type { get; set; }

        public List<OptionsDTO> Options { get; set; } = new List<OptionsDTO>();
    }
}
