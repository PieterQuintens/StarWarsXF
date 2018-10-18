using Microsoft.EntityFrameworkCore;
using StarWars.Data;
using StarWarsUniverse.Data;
using System;
using System.IO;
using StarWarsXF.ViewModels;
using StarWarsXF.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StarWarsXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // init database connection string
            string dbName = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "starwars.db");
            StarWarsContextFactory.ConnectionString = $"Data Source = {dbName}";

            using (StarWarsContext context = StarWarsContextFactory.Create())
            {
                context.Database.Migrate();
            };

            var mainView = new MainView
            {
                BindingContext = new MainViewModel()
            };
            
            MainPage = mainView;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
