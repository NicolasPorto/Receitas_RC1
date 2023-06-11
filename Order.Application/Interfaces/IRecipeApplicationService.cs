using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Request.RecipeImage;
using Order.Application.DataContract.Response.Recipe;
using Order.Application.DataContract.Response.RecipeImage;

namespace Order.Application.Interfaces.Services
{
    public interface IRecipeApplicationService
    {
        Task<RecipeResponse> CadastrarReceita(RecipeRequest recipe);
        Task<RecipeResponse> AlterarReceita(RecipeRequest recipe);
        Task DeletarReceita(Guid recipeCode);
        Task<RecipeResponse> GetReceitaByCode(Guid recipeCode);
        Task CadastrarImagem(RecipeImageRequest request);
        Task DeletarImagem(Guid codigoImage);
        Task<RecipeImageResponse> GetImageByCode(Guid codigoImage);
    }
}