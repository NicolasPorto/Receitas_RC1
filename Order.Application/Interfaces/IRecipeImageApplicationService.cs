using Order.Domain.Entities;

namespace Order.Application.Interfaces.Services
{
    public interface IRecipeImageApplicationService
    {
        Task CadastrarImagem(RecipeImage image);
        Task DeletarImagem(RecipeImage image);
        Task GetImageByCode(Guid imageCode);
    }
}