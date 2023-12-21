using AutoMapper;
using Order.Application.DataContract.Request.RecipeImage;
using Order.Application.DataContract.Response.RecipeImage;
using Order.Application.Interfaces.Services;
using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;

namespace Order.Application.ApplicationServices
{
    public class RecipeImageApplicationService : IRecipeImageApplicationService
    {
        private readonly IRecipeImageRepository _recipeImageRepository;
        private readonly IMapper _mapper;

        public RecipeImageApplicationService(IRecipeImageRepository recipeImageRepository, IMapper mapper)
        {
            _recipeImageRepository = recipeImageRepository;
            _mapper = mapper;
        }

        public async Task CreateImageRecipe(RecipeImageRequest request)
        {
            var recipeImage = _mapper.Map<RecipeImage>(request);

            await _recipeImageRepository.Insert(recipeImage);
        }

        public async Task DeleteImagem(Guid imageCode)
        {
            await _recipeImageRepository.Delete(imageCode);
        }

        public async Task<RecipeImageResponse> GetImageByCode(Guid imageCode)
        {
            var recipeImage = await _recipeImageRepository.GetById(imageCode);

            return _mapper.Map<RecipeImageResponse>(recipeImage);
        }
    }
}