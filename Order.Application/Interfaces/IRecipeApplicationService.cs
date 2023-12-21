using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Request.RecipeImage;
using Order.Application.DataContract.Response.Recipe;
using Order.Application.DataContract.Response.RecipeImage;

namespace Order.Application.Interfaces.Services
{
    public interface IRecipeApplicationService
    {
        Task<RecipeResponse> CreateRecipe(RecipeRequest recipe);
        Task<RecipeResponse> UpdateRecipe(RecipeRequest recipe);
        Task<RecipeResponse> GetRecipeByCode(Guid recipeCode);
        Task DeleteRecipe(Guid recipeCode);
        Task CreateImageRecipe(RecipeImageRequest request);
        Task DeleteImagem(Guid imageCode);
        Task<RecipeImageResponse> GetImageByCode(Guid imageCode);
    }
}