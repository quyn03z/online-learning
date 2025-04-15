using OnlineLearning.Models.Domains.Miscellaneous;

namespace OnlineLearning.Services.Interfaces
{
    public interface ITransactionService
    {
        public Task<bool> AddTransactionAsync(TransactionHistory transaction);
        Task<decimal> GetDailyRevenueAsync(DateTime date);
        Task<decimal> GetMonthlyRevenueAsync(DateTime date);
        Task<decimal> GetYearlyRevenueAsync(DateTime date);
    }
}
