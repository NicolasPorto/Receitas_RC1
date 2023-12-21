using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Request.RecipeImage;
using Order.Application.DataContract.Response.Recipe;
using Order.Application.DataContract.Response.RecipeImage;

namespace Order.Application.Interfaces.Services
{
    public interface IRecipeApplicationService
    {
        Task<RecipeResponse> RegisterRecipe(RecipeRequest recipe);
        Task<RecipeResponse> ChangeRecipe(RecipeRequest recipe);
        Task DeleteRecipe(Guid recipeCode);
        Task<RecipeResponse> SearchRecipeByCode(Guid recipeCode);
        Task RegisterImage(RecipeImageRequest request);
        Task DeleteImagem(Guid imageCode);
        Task<RecipeImageResponse> GetImageByCode(Guid imageCode);
    }
}