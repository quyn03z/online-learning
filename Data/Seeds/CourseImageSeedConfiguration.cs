using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels;

namespace OnlineLearning.Data.Seeds
{
    public class CourseImageSeedConfiguration : IEntityTypeConfiguration<CourseImageUrl>
    {
        public void Configure(EntityTypeBuilder<CourseImageUrl> builder)
        {
            builder.HasData(GetCourseImages());
        }

        private static List<CourseImageUrl> GetCourseImages()
        { 
            List<CourseImageUrl> courseImages = new List<CourseImageUrl>();
            for(int i = 1; i <= 10; i++)    
            {
                courseImages.Add(new CourseImageUrl
                {
                    Id = i,
                    CourseId = i,
                    Url = $"https://picsum.photos/{Faker.RandomNumber.Next(1000, 2000)}/{Faker.RandomNumber.Next(1000, 2000)}"
                });
            }
            return courseImages;
        }
    }
}