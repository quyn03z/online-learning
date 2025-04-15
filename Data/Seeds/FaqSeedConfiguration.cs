using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.Miscellaneous;

namespace OnlineLearning.Data.Seeds
{
    public class FaqSeedConfiguration : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> builder)
        {
            builder.HasData(GetFaqs());
        }

        private static List<FAQ> GetFaqs()
        { 
            List<FAQ> faqs = new List<FAQ>();
            for(int i = 1; i <= 100; i++)
            {
                faqs.Add(new FAQ
                {
                    FaqId = i,
                    Question = Faker.Lorem.Sentence(10),
                    Answer = Faker.Lorem.Paragraph(30),
                    CreatedAt = DateTime.Parse("2025-01-01"),
                    CommonStatus = Faker.Enum.Random<CommonStatus>()
                });
            }
            return faqs;
        }
    }
}