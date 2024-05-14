using CookBook.UI;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.ServiceProcess;

namespace CookBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ServiceCollection services = ConfigureServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            var startForm = serviceProvider.GetRequiredService<RecipesForm>();

            Application.Run(startForm);
        }

        static ServiceCollection ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

                services.AddTransient<IIngredientsRepository>(_ => new IngredientsRepository());
            services.AddTransient<IRecipeTypesRepository>(_ => new RecipeTypesRepository());
            services.AddTransient<IRecipesRepository>(_ => new RecipesRepository());

            services.AddTransient<IngredientsForm>();
            services.AddTransient<RecipesForm>();
            services.AddTransient<RecipeTypesForm>();
            services.AddTransient<RecipeIngredientsForm>();

            return services;
        }
    }
}