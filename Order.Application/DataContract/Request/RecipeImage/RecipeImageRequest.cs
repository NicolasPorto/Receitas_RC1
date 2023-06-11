namespace Order.Application.DataContract.Request.RecipeImage
{
    public class RecipeImageRequest
    {
        public Guid Codigo { get; set; }
        public Guid CodigoRecipe { get; set; }
        public string UrlImage { get; set; }
    }
}