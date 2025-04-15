using OnlineLearning.Models.Domains.CourseModels.CategoryModels;

namespace OnlineLearning.Services.Interfaces
{
    public interface ILevelService 
    {
        Task<IEnumerable<Level>> GetAllLevelAysnc();
        Task<Level> GetLevelByIdAsync(long id);
        Task AddLevelAsync(Level level);
        Task UpdateLevelAsync(Level level);
        Task DeleteLevelAsync(Level level);
    }
}
