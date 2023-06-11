using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Response.Recipe;

namespace Order.Application.Interfaces.Services
{
    public interface IRecipeApplicationService
    {
        Task<RecipeResponse> CadastrarReceita(RecipeRequest recipe);
        Task<RecipeResponse> AlterarReceita(RecipeRequest recipe);
        Task DeletarReceita(Guid recipeCode);
        Task<RecipeResponse> GetReceitaByCode(Guid recipeCode);
    }
}