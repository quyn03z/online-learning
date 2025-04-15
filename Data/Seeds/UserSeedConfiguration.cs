using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.UserModels;

namespace OnlineLearning.Data.Seeds
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(GetUsers());
        }

        private static List<User> GetUsers()
        { 
            List<User> users = new List<User>();
            User user1 = new User { UserId = 1, FullName = "My Admin", Email = "admin@admin.com", Password = "1", Dob = DateOnly.Parse("06-07-2003"), Phone = "0000000000", Gender = true };
			User user2 = new User { UserId = 2, FullName = "My Admin 2", Email = "admin2@admin.com", Password = "1", Dob = DateOnly.Parse("06-07-2003"), Phone = "0000000001", Gender = true };
			users.Add(user1);
			users.Add(user2);
            for(int i = 3; i <= 100; i++)
            {
                User user = new User { 
                    UserId = i,
                    FullName = Faker.Name.FullName(), 
                    Email = Faker.Internet.Email(),
                    Password = BCrypt.Net.BCrypt.HashPassword("123456"),
                    Dob = DateOnly.Parse("06-07-2003"),
                    Phone = (i + Faker.RandomNumber.Next(1000000000, 9999999999)).ToString(),
                    Gender = Faker.Boolean.Random(),
                    AvatarUrl = $"https://picsum.photos/200/200",
                    CreatedAt = DateTime.Parse("2025-01-01"),
                };
                users.Add(user);
            }
			return users;
        }
    }
}