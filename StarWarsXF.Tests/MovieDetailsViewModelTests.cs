using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.Domain;
using StarWarsXF.Services;
using StarWarsXF.Util;
using StarWarsXF.ViewModels;
using StarWarsXF.Views;
using Xamarin.Forms;

namespace StarWarsXF.Tests
{
    [TestFixture()]
    public class MovieDetailsViewModelTests
    {
        private MovieDetailsViewModel _movieDetailsViewModel;
        private MovieListViewModel _movieListViewModel;
        private Mock<IMovieRepository> _movieRepositoryMock;
        private Mock<INavigationService> _navigationServiceMock;
        private Movie _movie;

        [SetUp]
        public void Setup()
        {
            _navigationServiceMock = new Mock<INavigationService>();
            _movieRepositoryMock = new Mock<IMovieRepository>();
            _movieDetailsViewModel = new MovieDetailsViewModel(_navigationServiceMock.Object);
            _movieListViewModel = new MovieListViewModel(_movieRepositoryMock.Object, _navigationServiceMock.Object);
            _movie = new Movie
            {
                Rating = 5
            };
        }

        [Test]
        public void ShouldSetCurrentMovieWhenMessageIsReceived()
        {
            MessagingCenter.Instance.Send(_movieListViewModel, MessageConstants.MovieSelected, _movie);

            Assert.That(_movieDetailsViewModel.CurrentMovie, Is.EqualTo(_movie));
        }

        [Test]
        public void RateUpCommand_ShouldIncrementRating()
        {
            _movieDetailsViewModel.CurrentMovie = _movie;
            _movieDetailsViewModel.RateUpCommand.Execute(_movie);

            Assert.That(_movieDetailsViewModel.CurrentMovie.Rating, Is.EqualTo(5.5));
        }

        [Test]
        public void RateDownCommand_ShouldDecrementRating()
        {
            _movieDetailsViewModel.CurrentMovie = _movie;
            _movieDetailsViewModel.RateDownCommand.Execute(_movie);

            Assert.That(_movieDetailsViewModel.CurrentMovie.Rating, Is.EqualTo(4.5));
        }

        [Test]
        public void SettingCurrentMovieShouldReEvaluateCanExecuteForBothRatingCommands()
        {

            Assert.Fail();
        }

        [Test]
        public void RateUpCommand_ShouldReEvaluateCanExecuteForBothRatingCommands()
        {
            Assert.Fail();
        }

        [Test]
        public void RateDownCommand_ShouldReEvaluateCanExecuteForBothRatingCommands()
        {
            Assert.Fail();
        }

        [Test]
        public void RateUpCommand_CanExecute_ShouldBeTrueWhenSmallerThanTen()
        {
            Assert.Fail();
        }

        [Test]
        public void RateDownCommand_CanExecute_ShouldBeTrueWhenGreaterThanZero()
        {
            Assert.Fail();
        }

        [Test]
        public void ShowPlanetsCommand_ShouldTriggerNavigationAndSendPlanetsOfMovie()
        {
            Assert.Fail();
        }
    }
}
