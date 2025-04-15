using OnlineLearning.Models.Domains.Miscellaneous;

namespace OnlineLearning.Repositories.Interfaces
{
    public interface ITransactionRepository : IBaseRepository<TransactionHistory>
    {
        Task<TransactionHistory> GetTransactionByUserIdAndCourseId(long userId, long? coueseId);

        Task<decimal> GetDailyRevenueAsync(DateTime date);
        Task<decimal> GetMonthlyRevenueAsync(DateTime date);
        Task<decimal> GetYearlyRevenueAsync(DateTime date);
    }
}
