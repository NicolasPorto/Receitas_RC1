using Order.Domain.Models;

namespace Order.Domain.Entities
{
    public class RecipeImage : EntityBase
    {
        public Guid Codigo { get; set; }
        public string UrlImage { get; set; }
    }
}