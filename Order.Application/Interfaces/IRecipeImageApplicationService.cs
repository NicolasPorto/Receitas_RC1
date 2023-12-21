using Order.Application.DataContract.Request.RecipeImage;
using Order.Application.DataContract.Response.RecipeImage;

namespace Order.Application.Interfaces.Services
{
    public interface IRecipeImageApplicationService
    {
        Task CreateImageRecipe(RecipeImageRequest request);
        Task DeleteImagem(Guid imageCode);
        Task<RecipeImageResponse> GetImageByCode(Guid imageCode);
    }
}