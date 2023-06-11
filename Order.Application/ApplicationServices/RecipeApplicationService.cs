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
    }
}