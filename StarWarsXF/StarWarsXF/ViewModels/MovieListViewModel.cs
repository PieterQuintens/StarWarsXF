using System;
using System.Collections.Generic;
using System.Text;
using StarWars.Data;
using StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.Data.Repositories.Db;
using StarWarsUniverse.Domain;
using StarWarsXF.Services;
using StarWarsXF.Util;
using StarWarsXF.Views;
using Xamarin.Forms;

namespace StarWarsXF.ViewModels
{
    public class MovieListViewModel
    {
        private INavigationService _navigationService;

        public IList<Movie> Movies { get; set; }
        
        public Command MovieSelectedCommand => new Command<Movie>(OnMovieSelected);

        public MovieListViewModel(IMovieRepository repository, INavigationService navigationService)
        {
            Movies = repository.GetAllMovies();
            _navigationService = navigationService;
        }

        private async void OnMovieSelected(Movie movie)
        {

            await _navigationService.NavigateToAsync<MovieDetailsViewModel>();

            MessagingCenter.Instance.Send(this, MessageConstants.MovieSelected,movie);

            ////Navigate to the detail view
            //var mainView = (MainView)Application.Current.MainPage;
            //var detailNavigationPage = (NavigationPage)mainView.Detail;
            //var movieDetailsView = detailNavigationPage.CurrentPage as MovieDetailsView;
            //if (movieDetailsView == null)
            //{
            //    movieDetailsView = new MovieDetailsView
            //    {
            //        BindingContext = new MovieDetailsViewModel()
            //    };
            //    await detailNavigationPage.PushAsync(movieDetailsView);
            //}
            ////Set the selected movie
            //var viewModel = (MovieDetailsViewModel)movieDetailsView.BindingContext;
            //viewModel.CurrentMovie = movie;
        }
    }


}
