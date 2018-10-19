using StarWarsUniverse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarWars.Data;
using StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.Data.Repositories.Api;

namespace StarWarsXF.ViewModels
{
    public class PlanetsViewModel : ViewModelBase
    {
        private IList<Planet> _planet;

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
