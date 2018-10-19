using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
using StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.Domain;
using StarWarsXF.Services;
using StarWarsXF.Util;
using StarWarsXF.ViewModels;
using Xamarin.Forms;

namespace StarWarsXF.Tests
{
    [TestFixture]
    public class MovieListViewModelTests
    {
        private MovieListViewModel _sut;
        private Mock<IMovieRepository> _movieRepositoryMock;
        private Mock<INavigationService> _navigationServiceMock;
        private Mock<MovieListViewModel> _movieListViewMock;

        [SetUp]
        public void SetUp()
        {
            _movieRepositoryMock = new Mock<IMovieRepository>();
            _navigationServiceMock = new Mock<INavigationService>();
            _sut = new MovieListViewModel(_movieRepositoryMock.Object, _navigationServiceMock.Object);
            _movieListViewMock = new Mock<MovieListViewModel>();
        }
        [Test]
        public void Constructor_ShouldLoadAllMovies()
        {
            //Arrange
            var allMovies = new List<Movie>();
            _movieRepositoryMock = new Mock<IMovieRepository>();
            _movieRepositoryMock.Setup(repo => repo.GetAllMovies()).Returns(allMovies);
            //Act
            var sut = new MovieListViewModel(_movieRepositoryMock.Object,
                _navigationServiceMock.Object);
            //Assert
            Assert.That(sut.Movies, Is.EqualTo(allMovies));
            _movieRepositoryMock.Verify(repo => repo.GetAllMovies(),Times.Once);
        }
        [Test]
        public void MovieSelectedCommand_ShouldTriggerNavigationAndSendSelectedMovie()
        {
            //Arrange
            var selectedMovie = new Movie();
            Movie sentMovie = null;
            MessagingCenter.Instance.Subscribe<MovieListViewModel, Movie>(this,
                MessageConstants.MovieSelected,
                (sender, movie) => { sentMovie = movie; });
            //Act
            _sut.MovieSelectedCommand.Execute(selectedMovie);
            //Assert
            _navigationServiceMock.Verify(service => service.NavigateToAsync<MovieDetailsViewModel>(), Times.Once);
            Assert.That(sentMovie, Is.EqualTo(selectedMovie));
        }


    }
}

