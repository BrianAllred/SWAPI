using System.Collections.Generic;
using System.Threading.Tasks;
using SWAPI.Models;

namespace SWAPI.Extensions
{
    public static class FilmExtensions
    {
        public static async Task<IEnumerable<Species>> GetSpeciesAsync(this Film film, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Species>(film.species);
        }

        public static async Task<IEnumerable<Starship>> GetStarshipsAsync(this Film film, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Starship>(film.starships);
        }

        public static async Task<IEnumerable<Vehicle>> GetVehiclesAsync(this Film film, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Vehicle>(film.vehicles);
        }

        public static async Task<IEnumerable<People>> GetCharactersAsync(this Film film, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<People>(film.characters);
        }

        public static async Task<IEnumerable<Planet>> GetPlanetAsync(this Film film, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Planet>(film.planets);
        }
    }
}