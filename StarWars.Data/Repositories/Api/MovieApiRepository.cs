using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using StarWarsUniverse.Domain;

namespace StarWarsUniverse.Data.Repositories.Api
{
    public class MovieApiRepository : ApiRepositoryBase, IMovieRepository
    {
        public IList<Movie> GetAllMovies()
        {
            //var url = "/api/films";
            //var allMovies = new List<Movie>();
            //ResultsPage<Movie> resultsPage = null;

            //HttpResponseMessage response = _httpClient.GetAsync(url).Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    string content = response.Content.ReadAsStringAsync().Result;
            //    resultsPage = JsonConvert.DeserializeObject<ResultsPage<Movie>>(content);
            //    allMovies = resultsPage.Results;
            //}

            //return allMovies;

            return GetAllStarWarsResources<Movie>("/api/films");
        }
    }
}
