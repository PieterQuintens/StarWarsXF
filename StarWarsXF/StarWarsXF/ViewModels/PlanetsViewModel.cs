using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarWars.Data;
using StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.Data.Repositories.Api;
using StarWarsXF.Util;
using Xamarin.Forms;

namespace StarWarsXF.ViewModels
{
    public class PlanetsViewModel : ViewModelBase
    {
        private IList<Planet> _planet;

        public PlanetsViewModel()
        {
            MessagingCenter.Instance.Subscribe<MovieDetailsViewModel,
                List<Planet>>(this, MessageConstants.ShowMoviePlanets,
                (sender, planets) => { Planets = planets; });
        }

        public IList<Planet> Planets
        {
            get => _planet;
            set
            {
                _planet = value;
                OnPropertyChanged();
            }
        }
    }
}
