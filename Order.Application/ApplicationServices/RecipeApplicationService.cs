using AutoMapper;
using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Request.RecipeImage;
using Order.Application.DataContract.Response.Recipe;
using Order.Application.DataContract.Response.RecipeImage;
using Order.Application.Interfaces.Services;
using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;

namespace Order.Application.ApplicationServices
{
    public class RecipeApplicationService : IRecipeApplicationService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IRecipeImageRepository _recipeImageRepository;
        private readonly IMapper _mapper;

        public RecipeApplicationService(IRecipeImageRepository recipeImageRepository, IRecipeRepository recipeRepository, IMapper mapper)
        {
            _recipeRepository = recipeRepository;
            _recipeImageRepository = recipeImageRepository;
            _mapper = mapper;
        }

        #region Recipe

        public async Task<RecipeResponse> RegisterRecipe(RecipeRequest request)
        {
            var recipe = _mapper.Map<Recipe>(request);

            await _recipeRepository.Insert(recipe);

            return _mapper.Map<RecipeResponse>(recipe);
        }

        public async Task<RecipeResponse> ChangeRecipe(RecipeRequest request)
        {
            var recipe = _mapper.Map<Recipe>(request);

            await _recipeRepository.Update(recipe);

            return _mapper.Map<RecipeResponse>(recipe);
        }

        public async Task DeleteRecipe(Guid recipeCode)
        {
            await _recipeRepository.Delete(recipeCode);
        }

        public async Task<RecipeResponse> SearchRecipeByCode(Guid recipeCode)
        {
            var recipe = await _recipeRepository.GetById(recipeCode);

            return _mapper.Map<RecipeResponse>(recipe);
        }

        #endregion

        #region RecipeImage

        public async Task RegisterImage(RecipeImageRequest request)
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

        #endregion
    }
}