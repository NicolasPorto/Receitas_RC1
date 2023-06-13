using Order.Domain.Entities;
using Order.Domain.Interfaces.Repositories;
using System.Data;

namespace Order.Infra.Repositories
{
    public class RecipeImageRepository : IRecipeImageRepository
    {
        private readonly IDbConnection _dbConnection;

        public RecipeImageRepository(IDbConnection dbConnection) 
        {
            _dbConnection = dbConnection;
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