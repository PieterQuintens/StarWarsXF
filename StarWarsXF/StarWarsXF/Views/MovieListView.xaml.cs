﻿using System.Collections.Generic;
using StarWars.Data;
using StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.Data.Repositories.Db;
using StarWarsUniverse.Domain;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsXF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MovieListView : ContentPage
	{
        //public ListView MyListView { get; private set; }

        public MovieListView ()
		{
			InitializeComponent ();

            //SWMoviesListView.ItemsSource = movieList;
            
            //MyListView = SWMoviesListView;
        }
    }
}