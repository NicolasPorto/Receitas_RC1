using AutoMapper;
using Order.Application.DataContract.Request.Recipe;
using Order.Application.DataContract.Response.Recipe;
using Order.Application.Interfaces.Services;
using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;

namespace Order.Application.ApplicationServices
{
    public class RecipeApplicationService : IRecipeApplicationService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IMapper _mapper;

        public RecipeApplicationService(IRecipeRepository recipeRepository, IMapper mapper)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<RecipeResponse> CreateRecipe(RecipeRequest request)
        {
            var recipe = _mapper.Map<Recipe>(request);

            await _recipeRepository.Insert(recipe);

            return _mapper.Map<RecipeResponse>(recipe);
        }

        public async Task<RecipeResponse> UpdateRecipe(RecipeRequest request)
        {
            var recipe = _mapper.Map<Recipe>(request);

            await _recipeRepository.Update(recipe);

            return _mapper.Map<RecipeResponse>(recipe);
        }

        public async Task DeleteRecipe(Guid recipeCode)
        {
            await _recipeRepository.Delete(recipeCode);
        }

        public async Task<RecipeResponse> GetRecipeByCode(Guid recipeCode)
        {
            var recipe = await _recipeRepository.GetById(recipeCode);

            return _mapper.Map<RecipeResponse>(recipe);
        }
    }
}