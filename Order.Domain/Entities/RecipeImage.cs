using Order.Domain.Models;

namespace Order.Domain.Entities
{
    public class RecipeImage : EntityBase
    {
        public Guid Code { get; set; }
        public Guid CodigoRecipe { get; set; }
        public string UrlImage { get; set; }
        public Guid UserCode { get; set; }
    }
}