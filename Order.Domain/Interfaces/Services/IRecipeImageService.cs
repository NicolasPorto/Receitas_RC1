using Order.Domain.Entities;

namespace Order.Domain.Interfaces.Services
{
    public interface IRecipeImageService
    {
        Task CadastrarImagem(RecipeImage image);
        Task DeletarImagem(RecipeImage image);
        Task<RecipeImage> GetImageByCode(Guid imageCode);
    }
}