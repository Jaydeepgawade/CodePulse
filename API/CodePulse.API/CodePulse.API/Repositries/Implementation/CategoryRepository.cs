using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Repositries.Interface;

namespace CodePulse.API.Repositries.Implementation
{
    public class CategoryRepository : ICatrgoryRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
