using Order.Domain.Entities;
using Order.Domain.Interfaces.DataConnector;
using Order.Domain.Interfaces.Repositories;

namespace Order.Infra.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IDbConnector _dbConnector;

        public RecipeRepository(IDbConnector dbConnector) 
        {
            _dbConnector = dbConnector;
        }

        public Task Delete(Guid recipeCode)
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> GetById(Guid recipeCode)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Task Update(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}