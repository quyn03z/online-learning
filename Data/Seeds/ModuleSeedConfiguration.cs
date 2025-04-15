using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels;

namespace OnlineLearning.Data.Seeds
{
    public class ModuleSeedConfiguration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasData(GetModules());
        }

        private static List<Module> GetModules()
        {
            List<Module> modules = new List<Module>();
            for(int i = 1; i <= 100; i++)
            {
                modules.Add(new Module
                {
                    ModuleId = i,
                    CourseId = Faker.RandomNumber.Next(1, 10),
                    ModuleName = Faker.Lorem.Sentence(3),
                    CreatedAt = DateTime.Parse("2025-01-01"),
                    Status = Faker.Enum.Random<CommonStatus>(),
                    ModuleNumber = Faker.RandomNumber.Next(1, 10)
                });
            }
            return modules;
        }
    }
}