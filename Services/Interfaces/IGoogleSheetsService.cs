using OnlineLearning.Models.DTOs;

namespace OnlineLearning.Services.Interfaces
{
    public interface IGoogleSheetsService
    {
        Task UpdateRevenueAsync(RevenueDto revenue);
    }
}
