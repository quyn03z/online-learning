using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels;
using OnlineLearning.Models.Domains.UserModels;

namespace OnlineLearning.Data.Seeds
{
    public class CourseSeedConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(GetCourses());
        }

        private static List<Course> GetCourses()
        { 
            List<Course> courses = new List<Course>();
            for(int i = 1; i <= 10; i++)    
            {
                courses.Add(new Course
                {
                    CourseId = i,
                    CourseName = Faker.Lorem.Sentence(10),
                    Description = Faker.Lorem.Paragraph(100),
                    Price = Faker.RandomNumber.Next(0, 10000000),
                    Discount = Faker.RandomNumber.Next(0, 100),
                    Creator = Faker.RandomNumber.Next(1, 100),
                    Acceptor = Faker.RandomNumber.Next(1, 100),
                    CreatedAt = DateTime.Parse("2025-01-01"),
                    UpdatedAt = DateTime.Parse("2025-01-01"),
                    Status = Faker.Enum.Random<CourseStatus>(),
                    LanguageId = Faker.RandomNumber.Next(1, 15),
                    LevelId = Faker.RandomNumber.Next(1, 3)
                });
            }
            return courses;
        }
    }
}