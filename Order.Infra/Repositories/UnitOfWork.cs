using Order.Domain.Interfaces.DataConnector;
using Order.Domain.Interfaces.Repositories;

namespace Order.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUserRepository _userRepository;
        private IRecipeRepository _recipeRepository;
        private IRecipeImageRepository _recipeImageRepository;

        public IRecipeImageRepository RecipeImageRepository => _recipeImageRepository ?? (_recipeImageRepository = new RecipeImageRepository(DbConnector.DbConnection));
        public IRecipeRepository RecipeRepository => _recipeRepository ?? (_recipeRepository = new RecipeRepository(DbConnector.DbConnection));

        public IUserRepository UserRepository => _userRepository ?? (_userRepository = new UserRepository(DbConnector.DbConnection));

        public IDbConnector DbConnector => throw new NotImplementedException();

        public void BeginTransaction()
        {
            if (DbConnector.DbConnection.State == System.Data.ConnectionState.Open)
                DbConnector.DbTransaction = DbConnector.DbConnection.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);
        }

        public void CommitTransaction()
        {
            if (DbConnector.DbConnection.State == System.Data.ConnectionState.Open)
                DbConnector.DbTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            if (DbConnector.DbConnection.State == System.Data.ConnectionState.Open)
                DbConnector.DbTransaction.Commit();
        }
    }
}