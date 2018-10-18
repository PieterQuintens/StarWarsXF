using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using StarWarsUniverse.Domain;
using StarWarsXF.Views;
using Xamarin.Forms;

namespace StarWarsXF.ViewModels
{
    public class MovieDetailsViewModel : ViewModelBase
    {
        private Movie _currentMovie;
        private Command _rateDownCommand;
        private Command _rateUpCommand;

        public Movie CurrentMovie
        {
            get => _currentMovie;
            set
            {
                if (_currentMovie == value) return;
                _currentMovie = value;
                OnPropertyChanged();
                ChangeCanExecuteRating();
            }
        }

        private void ChangeCanExecuteRating()
        {
            RateUpCommand.ChangeCanExecute();
            RateDownCommand.ChangeCanExecute();
        }

        public Command RateDownCommand => _rateDownCommand ?? (_rateDownCommand = new Command(OnRateDown, OnCanExecuteRateDown));

        public Command RateUpCommand => _rateUpCommand ?? (_rateUpCommand = new Command(OnRateUp, OnCanExecuteRateUp));

        //public Command RateDownCommand => new Command(OnRateDown, OnCanExecuteRateDown);

        //public Command RateUpCommand => new Command(OnRateUp, OnCanExecuteRateUp);

        private bool OnCanExecuteRateUp()
        {
            return _currentMovie?.Rating < 10;
            //return true;
        }

        private void OnRateUp()
        {
            _currentMovie.Rating += 0.5f;
            ChangeCanExecuteRating();
        }

        private bool OnCanExecuteRateDown()
        {
            return _currentMovie?.Rating > 0;
            //return true;
        }

        private void OnRateDown()
        {
            _currentMovie.Rating -= 0.5f;
            ChangeCanExecuteRating();
        }

        private async void OnShowPlanets()
        {
            //Navigate to the detail view
            var mainView = (MainView)Application.Current.MainPage;
            var detailNavigationPage = (NavigationPage)mainView.Detail;
            var planetsView = new PlanetsView
            {
                BindingContext = new PlanetsViewModel()
            };
            await detailNavigationPage.PushAsync(planetsView);
            //Set planets
            var viewModel = (PlanetsViewModel)planetsView.BindingContext;
            //viewModel.Planets = CurrentMovie.MoviePlanets.Select(mp => mp.Planet).ToList(); TODO: add Planets property to PlanetsViewModel
        }
    }
}
