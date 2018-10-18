using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsXF.ViewModels
{
    public class MainViewModel
    {
        public MovieListViewModel MovieListViewModel { get; set; }

        public MainViewModel()
        {
            MovieListViewModel = new MovieListViewModel();
        }
    }
}
