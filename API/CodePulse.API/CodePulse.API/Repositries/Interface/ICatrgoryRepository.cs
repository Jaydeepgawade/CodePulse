using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositries.Interface
{
    public interface ICatrgoryRepository
    {
        Task<Category>CreateAsync(Category category);


    }
}
