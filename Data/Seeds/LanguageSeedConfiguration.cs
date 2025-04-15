using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;

namespace OnlineLearning.Data.Seeds
{
    public class LanguageSeedConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(GetLanguages());
        }

        private static List<Language> GetLanguages()
        {
            return new List<Language>
            {
                new Language
                {
                    LanguageId = 1,
                    LanguageName = "English",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 2,
                    LanguageName = "Spanish",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 3,
                    LanguageName = "Mandarin Chinese",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 4,
                    LanguageName = "Hindi",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 5,
                    LanguageName = "Arabic",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 6,
                    LanguageName = "Bengali",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 7,
                    LanguageName = "Portuguese",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 8,
                    LanguageName = "Russian",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 9,
                    LanguageName = "Japanese",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 10,
                    LanguageName = "Vietnamese",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 11,
                    LanguageName = "Korean",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 12,
                    LanguageName = "French",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 13,
                    LanguageName = "German",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 14,
                    LanguageName = "Italian",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                },
                new Language
                {
                    LanguageId = 15,
                    LanguageName = "Turkish",
                    CreatedAt = DateTime.Parse("2025-03-28 13:27:15"),
                    Status = CategoryStatus.Showed
                }
            };
        }
    }
}
