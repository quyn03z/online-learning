using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.UserModels;

namespace OnlineLearning.Data.Seeds
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(GetUserRoles());
        }

        private static List<UserRole> GetUserRoles()
        { 
            List<UserRole> userRoles = new List<UserRole>();
            UserRole userRole1 = new UserRole { UserId = 1, RoleId = 1 };
            UserRole userRole2 = new UserRole { UserId = 2, RoleId = 1 };
            userRoles.Add(userRole1);
            userRoles.Add(userRole2);
            for(int i = 3; i <= 100; i++)
            {
                userRoles.Add(
                    new UserRole { 
                        UserId = i, 
                        RoleId = Faker.RandomNumber.Next(1, 3)
                    }
                );
            }
            return userRoles;
        }
    }
}