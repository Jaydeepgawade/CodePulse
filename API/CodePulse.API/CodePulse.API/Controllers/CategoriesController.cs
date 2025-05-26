using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using CodePulse.API.Repositries.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    ///http://localhost:xxxx/api/Categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICatrgoryRepository catrgoryRepository;

        public CategoriesController(ICatrgoryRepository catrgoryRepository)
        {
           this.catrgoryRepository = catrgoryRepository;
        }

        
        //
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            // MAP DTO to Domain Model

            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };

            await catrgoryRepository.CreateAsync(category);
            // Domain model to DTO

            var response = new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = request.UrlHandle,
            };

            return Ok(response);
        }
    }
}
