using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Response.Recipe;

namespace Order.Application.Interfaces.Services
{
    public interface IRecipeApplicationService
    {
        Task<RecipeResponse> CreateRecipe(RecipeRequest recipe);
        Task<RecipeResponse> UpdateRecipe(RecipeRequest recipe);
        Task<RecipeResponse> GetRecipeByCode(Guid recipeCode);
        Task DeleteRecipe(Guid recipeCode);
    }
}