using Order.Domain.Messaging.Api;

namespace Order.Application.DataContract.Response.Recipe
{
    public class RecipeResponse : ResponseBase
    {
        public Guid Codigo { get; set; }
        public string Title { get; set; }
        public string DescriptionRecipe { get; set; }
        public string TypeRecipe { get; set; }
        public Guid? ImageCode { get; set; }
        public bool HasImage { get; set; }
    }
}