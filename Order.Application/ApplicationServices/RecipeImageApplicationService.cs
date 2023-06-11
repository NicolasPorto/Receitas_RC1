using Order.Application.Interfaces.Services;
using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;

namespace Order.Application.ApplicationServices
{
    public class RecipeImageApplicationService : IRecipeImageApplicationService
    {
        private readonly IRecipeImageRepository _recipeImageRepository;

        public RecipeImageApplicationService(IRecipeImageRepository recipeImageRepository)
        {
            _recipeImageRepository = recipeImageRepository;
        }

        public Task CadastrarImagem(RecipeImage image)
        {
            return _recipeImageRepository.Insert(image);
        }

        public Task DeletarImagem(RecipeImage image)
        {
            return _recipeImageRepository.Delete(image.Codigo);
        }

        public Task GetImageByCode(Guid imageCode)
        {
            return _recipeImageRepository.GetById(imageCode);
        }
    }
}