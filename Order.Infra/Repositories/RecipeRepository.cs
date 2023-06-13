using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;
using System.Data;

namespace Order.Infra.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IDbConnection _dbConnection;

        public RecipeRepository(IDbConnection dbConnection) 
        {
            _dbConnection = dbConnection;
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