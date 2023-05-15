using Order.Domain.Entities;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IRecipeImageRepository
    {
        Task Insert(RecipeImage recipeImage);
        Task Update(Recipe recipeImage);
        Task Delete(Guid recipeImageCode);
        Task<Recipe> GetById(Guid recipeImageCode);
    }
}
