using Order.Application.Messaging.Api;

namespace Order.Application.DataContract.Response.RecipeImage
{
    public class RecipeImageResponse : ResponseBase
    {
        public Guid Codigo { get; set; }
        public Guid CodigoRecipe { get; set; }
        public string UrlImage { get; set; }
    }
}