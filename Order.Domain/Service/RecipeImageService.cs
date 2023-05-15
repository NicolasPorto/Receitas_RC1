using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;

namespace Order.Domain.Service
{
    public class RecipeImageService : IRecipeImageService
    {
        private readonly IRecipeImageRepository _recipeImageRepository;

        public RecipeImageService(IRecipeImageRepository recipeImageRepository)
        {
            _recipeImageRepository = recipeImageRepository;
        }

        public Task CadastrarImagem(RecipeImage image)
        {

        }

        public Task DeletarImagem(RecipeImage image)
        {

        }

        public Task<RecipeImage> GetImageByCode(Guid imageCode)
        {

        }
    }
}