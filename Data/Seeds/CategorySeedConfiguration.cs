using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;

namespace OnlineLearning.Data.Seeds
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GetCategories());
        }

        private static List<Category> GetCategories()
        { 
            return new List<Category>
            {
                new Category { 
                    CategoryId = 1,
                    CategoryName = "Business" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                },
                new Category { 
                    CategoryId = 2,
                    CategoryName = "Information Technology" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                },
                new Category { 
                    CategoryId = 3,
                    CategoryName = "Health" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                },
                new Category { 
                    CategoryId = 4,
                    CategoryName = "Arts" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                },
                new Category { 
                    CategoryId = 5,
                    CategoryName = "Sports" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                },
                new Category { 
                    CategoryId = 6,
                    CategoryName = "Others" ,
                    CreatedAt = DateTime.Parse("2025-03-28 14:20:00"),
                    Status = CategoryStatus.Showed
                }
            };
        }
    }
}