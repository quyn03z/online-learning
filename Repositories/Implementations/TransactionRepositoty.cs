using Microsoft.EntityFrameworkCore;
using OnlineLearning.Data;
using OnlineLearning.Models.Domains.Miscellaneous;
using OnlineLearning.Repositories.Interfaces;

namespace OnlineLearning.Repositories.Implementations
{
    public class TransactionRepositoty : BaseRepository<TransactionHistory>, ITransactionRepository
    {
        public TransactionRepositoty(OnlLearnDBContext context) : base(context) { }

        public async Task<TransactionHistory> GetTransactionByUserIdAndCourseId(long userId, long? coueseId)
        {
            return await _context.TransactionHistories.FirstOrDefaultAsync(x => x.UserId == userId && x.CourseId == coueseId);
        }

        public async Task<decimal> GetDailyRevenueAsync(DateTime date)
        {
            return await _context.TransactionHistories
                .Where(t => t.Status == Enums.TransactionStatus.Completed && t.CreatedAt.Date == date.Date)
                .SumAsync(t => t.Amount);
        }

        public async Task<decimal> GetMonthlyRevenueAsync(DateTime date)
        {
            return await _context.TransactionHistories
                .Where(t => t.Status == Enums.TransactionStatus.Completed && t.CreatedAt.Year == date.Year && t.CreatedAt.Month == date.Month)
                .SumAsync(t => t.Amount);
        }

        public async Task<decimal> GetYearlyRevenueAsync(DateTime date)
        {
            return await _context.TransactionHistories
                .Where(t => t.Status == Enums.TransactionStatus.Completed && t.CreatedAt.Year == date.Year)
                .SumAsync(t => t.Amount);
        }
    }
}
