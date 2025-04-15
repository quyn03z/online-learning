using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineLearning.Enums;
using OnlineLearning.Models.Domains.CourseModels.CategoryModels;
using OnlineLearning.Services.Interfaces;

namespace OnlineLearning.Areas.Admin.Controllers
{
    [Authorize(Roles = nameof(RoleType.ADMIN))]
    [Area("Admin")]
    public class SettingsCourseCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ILanguageService _languageService;
        private readonly ILevelService _levelService;

        public SettingsCourseCategoryController(
            ICategoryService categoryService,
            ILanguageService languageService,
            ILevelService levelService)
        {
            _categoryService = categoryService;
            _languageService = languageService;
            _levelService = levelService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            ViewBag.Categories = await _categoryService.GetAllCategoryAysnc();
            ViewBag.Languages = await _languageService.GetAllLanguageAysnc();
            ViewBag.Levels = await _levelService.GetAllLevelAysnc();
            return View();
        }
        #endregion

        #region Category
        public async Task<IActionResult> Categories()
        {
            var categories = await _categoryService.GetAllCategoryAysnc();
            return View(categories);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                category.CreatedAt = DateTime.Now;
                category.Status = CategoryStatus.Showed;
                
                await _categoryService.AddCategoryAsync(category);
                
                return RedirectToAction(nameof(Categories));
            }
            return View(category);
        }

        public async Task<IActionResult> EditCategory(long id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            
            if (category == null)
            {
                return NotFound();
            }
            
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(long id, Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                category.UpdatedAt = DateTime.Now;
                
                await _categoryService.UpdateCategoryAsync(category);
                
                return RedirectToAction(nameof(Categories));
            }
            return View(category);
        }

        public async Task<IActionResult> DeleteCategory(long id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            
            if (category == null)
            {
                return NotFound();
            }
            
            return View(category);
        }

        [HttpPost, ActionName("DeleteCategory")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategoryConfirmed(long id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            
            if (category != null)
            {
                category.DeletedAt = DateTime.Now;
                category.Status = CategoryStatus.Deleted;
                
                await _categoryService.DeleteCategoryAsync(category);
            }
            
            return RedirectToAction(nameof(Categories));
        }
        #endregion

        #region Language
        public async Task<IActionResult> Languages()
        {
            var languages = await _languageService.GetAllLanguageAysnc();
            return View(languages);
        }

        public IActionResult CreateLanguage()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLanguage(Language language)
        {
            if (ModelState.IsValid)
            {
                language.CreatedAt = DateTime.Now;
                language.Status = CategoryStatus.Showed;
                
                await _languageService.AddLanguageAsync(language);
                
                return RedirectToAction(nameof(Languages));
            }
            return View(language);
        }

        public async Task<IActionResult> EditLanguage(long id)
        {
            var language = await _languageService.GetLanguageByIdAsync(id);
            
            if (language == null)
            {
                return NotFound();
            }
            
            return View(language);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditLanguage(long id, Language language)
        {
            if (id != language.LanguageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                language.UpdatedAt = DateTime.Now;
                
                await _languageService.UpdateLanguageAsync(language);
                
                return RedirectToAction(nameof(Languages));
            }
            return View(language);
        }

        public async Task<IActionResult> DeleteLanguage(long id)
        {
            var language = await _languageService.GetLanguageByIdAsync(id);
            
            if (language == null)
            {
                return NotFound();
            }
            
            return View(language);
        }

        [HttpPost, ActionName("DeleteLanguage")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteLanguageConfirmed(long id)
        {
            var language = await _languageService.GetLanguageByIdAsync(id);
            
            if (language != null)
            {
                language.DeletedAt = DateTime.Now;
                language.Status = CategoryStatus.Deleted;
                
                await _languageService.DeleteLanguageAsync(language);
            }
            
            return RedirectToAction(nameof(Languages));
        }
        #endregion

        #region Level
        public async Task<IActionResult> Levels()
        {
            var levels = await _levelService.GetAllLevelAysnc();
            return View(levels);
        }

        public IActionResult CreateLevel()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLevel(Level level)
        {
            if (ModelState.IsValid)
            {
                level.CreatedAt = DateTime.Now;
                level.Status = CategoryStatus.Showed;
                
                await _levelService.AddLevelAsync(level);
                
                return RedirectToAction(nameof(Levels));
            }
            return View(level);
        }

        public async Task<IActionResult> EditLevel(long id)
        {
            var level = await _levelService.GetLevelByIdAsync(id);
            
            if (level == null)
            {
                return NotFound();
            }
            
            return View(level);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditLevel(long id, Level level)
        {
            if (id != level.LevelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                level.UpdatedAt = DateTime.Now;
                
                await _levelService.UpdateLevelAsync(level);
                
                return RedirectToAction(nameof(Levels));
            }
            return View(level);
        }

        public async Task<IActionResult> DeleteLevel(long id)
        {
            var level = await _levelService.GetLevelByIdAsync(id);
            
            if (level == null)
            {
                return NotFound();
            }
            
            return View(level);
        }

        [HttpPost, ActionName("DeleteLevel")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteLevelConfirmed(long id)
        {
            var level = await _levelService.GetLevelByIdAsync(id);
            
            if (level != null)
            {
                level.DeletedAt = DateTime.Now;
                level.Status = CategoryStatus.Deleted;
                
                await _levelService.DeleteLevelAsync(level);
            }
            
            return RedirectToAction(nameof(Levels));
        }
        #endregion
    }
}
