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

        public async Task<RecipeResponse> CadastrarReceita(RecipeRequest request)
        {
            var recipe = _mapper.Map<Recipe>(request);

            await _recipeRepository.Insert(recipe);

            var response = _mapper.Map<RecipeResponse>(recipe);

            return response;
        }

        public async Task<RecipeResponse> AlterarReceita(RecipeRequest request)
        {
            var recipe = _mapper.Map<Recipe>(request);

            await _recipeRepository.Update(recipe);

            var response = _mapper.Map<RecipeResponse>(recipe);

            return response;
        }

        public async Task DeletarReceita(Guid codigoRecipe)
        {
            await _recipeRepository.Delete(codigoRecipe);
        }

        public async Task<RecipeResponse> GetReceitaByCode(Guid codigoRecipe)
        {
            var recipe = await _recipeRepository.GetById(codigoRecipe);

            var response = _mapper.Map<RecipeResponse>(recipe);

            return response;
        }

        #endregion

        #region RecipeImage

        public async Task CadastrarImagem(RecipeImageRequest request)
        {
            var recipeImage = _mapper.Map<RecipeImage>(request);

            await _recipeImageRepository.Insert(recipeImage);
        }

        public async Task DeletarImagem(Guid codigoImage)
        {
            await _recipeImageRepository.Delete(codigoImage);
        }

        public async Task<RecipeImageResponse> GetImageByCode(Guid codigoImage)
        {
            var recipeImage = await _recipeImageRepository.GetById(codigoImage);

            var response = _mapper.Map<RecipeImageResponse>(recipeImage);

            return response;
        }

        #endregion
    }
}