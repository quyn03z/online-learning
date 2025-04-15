using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearning.Models.Domains.UserModels;
using Faker;

namespace OnlineLearning.Data.Seeds
{
    public class WalletSeedConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasData(GetWallets());
        }

        private static List<Wallet> GetWallets()
        { 
            List<Wallet> wallets = new List<Wallet>();
            for(int i = 1; i <= 100; i++)    
            {
                wallets.Add(new Wallet
                {
                    WalletId = i,
                    Balance = Faker.RandomNumber.Next(0, 10000000),
                    CurrencyCode = "VND",
                    CreatedAt = DateTime.Parse("2025-01-01"),
                });
            }
            return wallets;
        }
    }
}