using Order.Domain.Models;
using Order.Infra.Enums;

namespace Order.Domain.Entities
{
    public class Recipe : EntityBase
    {
        public Guid Code { get; set; }
        public string Title { get; set; }
        public string DescriptionRecipe { get; set; }
        public string TypeRecipe { get; set; }
        public Guid? ImageCode { get; set; }
        public bool HasImage { get; set; }
        public Guid UserCode { get; set; }
        public Situation Situation { get; set; }
    }
}