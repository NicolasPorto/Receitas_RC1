using Order.Domain.Interfaces.DataConnector;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IRecipeImageRepository RecipeImageRepository { get; }
        IRecipeRepository RecipeRepository { get; } 
        IUserRepository UserRepository { get; }
        IDbConnector DbConnector { get; }

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}