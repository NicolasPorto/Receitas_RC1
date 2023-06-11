using Order.Domain.Entities;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IRecipeImageRepository
    {
        Task Insert(RecipeImage recipeImage);
        Task Update(RecipeImage recipeImage);
        Task Delete(Guid recipeImageCode);
        Task<RecipeImage> GetById(Guid recipeImageCode);
    }
}