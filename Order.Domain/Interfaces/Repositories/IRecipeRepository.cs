using Order.Domain.Entities;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IRecipeRepository
    {
        Task Insert(Recipe recipe);
        Task Update(Recipe recipe);
        Task Delete(Guid recipeCode);
        Task<Recipe> GetById(Guid recipeCode);
    }
}