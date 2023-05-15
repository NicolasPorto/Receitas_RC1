using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;

namespace Order.Domain.Service
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public Task CadastrarReceita(Recipe recipe)
        {

        }

        public Task AlterarReceita(Recipe recipe)
        {

        }

        public Task DeletarReceita(Recipe recipe)
        {

        }

        public Task<Recipe> GetReceitaByCode(Guid recipeCode)
        {

        }
    }
}
