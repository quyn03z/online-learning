using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;

namespace OnlineLearning.Data.Seeds
{
    public class LevelSeedConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasData(GetLevels());
        }

        private static List<Level> GetLevels()
        { 
            return new List<Level>
            {
                new Level { 
                    LevelId = 1,
                    LevelName = "Beginner" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                },
                new Level { 
                    LevelId = 2,
                    LevelName = "Intermediate" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                },
                new Level { 
                    LevelId = 3,
                    LevelName = "Advanced" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                }
            };
        }
    }
}