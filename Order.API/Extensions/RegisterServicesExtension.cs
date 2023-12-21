using Order.Application.ApplicationServices;
using Order.Application.Interfaces.Services;
using Order.Domain.Interfaces.Repositories;
using Order.Infra.Repositories;

namespace Order.API.Extensions
{
    public static class RegisterServicesExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IUserApplicationService, UserApplicationService>();
            services.AddTransient<IRecipeApplicationService, RecipeApplicationService>();
            services.AddTransient<IRecipeImageApplicationService, RecipeImageApplicationService>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRecipeRepository, RecipeRepository>();
            services.AddTransient<IRecipeImageRepository, RecipeImageRepository>();
        }
    }
}
