using Order.Domain.Entities;
using Order.Domain.Interfaces.DataConnector;
using Order.Domain.Interfaces.Repositories;

namespace Order.Infra.Repositories
{
    public class RecipeImageRepository : IRecipeImageRepository
    {
        private readonly IDbConnector _dbConnector;

        public RecipeImageRepository(IDbConnector dbConnector) 
        {
            _dbConnector = dbConnector;
        }

        public Task Delete(Guid recipeImageCode)
        {
            throw new NotImplementedException();
        }

        public Task<RecipeImage> GetById(Guid recipeImageCode)
        {
            throw new NotImplementedException();
        }

        public Task Insert(RecipeImage recipeImage)
        {
            throw new NotImplementedException();
        }

        public Task Update(RecipeImage recipeImage)
        {
            throw new NotImplementedException();
        }
    }
}