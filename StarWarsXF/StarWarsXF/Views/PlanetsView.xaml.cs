﻿using StarWarsUniverse.Domain;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanetsView : ContentPage
    {
        public PlanetsView()
        {
            InitializeComponent();
        }

        //internal void FillPlanetDetails(Movie movie)
        //{
        //    this.PlanetsListView.ItemsSource = movie.MoviePlanets;
        //}
    }
}