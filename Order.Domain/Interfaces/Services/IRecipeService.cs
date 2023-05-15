using Order.Domain.Entities;

namespace Order.Domain.Interfaces.Services
{
    public interface IRecipeService
    {
        Task CadastrarReceita(Recipe recipe);
        Task AlterarReceita(Recipe recipe);
        Task DeletarReceita(Recipe recipe);
        Task<Recipe> GetReceitaByCode(Guid recipeCode);
    }
}