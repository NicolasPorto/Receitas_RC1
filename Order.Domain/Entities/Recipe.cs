using Order.Domain.Models;

namespace Order.Domain.Entities
{
    public class Recipe : EntityBase
    {
        public Guid Codigo { get; set; }
        public string Title { get; set; }
        public string DescriptionRecipe { get; set; }
        public string TypeRecipe { get; set; }
        public Guid? ImageCode { get; set; }
        public bool HasImage { get; set; }
    }
}