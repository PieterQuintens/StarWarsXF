using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarWarsUniverse.Data;
using StarWarsUniverse.Data.Repositories;
using StarWarsUniverse.Domain;

namespace StarWars.Data.Repositories.Db
{
    public class PlanetDbRepository : IPlanetRepository
    {
        private readonly StarWarsContext _context;

        public PlanetDbRepository(StarWarsContext context)
        {
            _context = context;
        }

        public IList<Planet> GetAllPlanets()
        {
            return _context.Planets.ToList();
        }
    }
}
