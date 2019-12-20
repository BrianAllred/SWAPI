using System.Collections.Generic;
using System.Threading.Tasks;
using SWAPI.Models;

namespace SWAPI.Extensions
{
    public static class PeopleExtensions
    {
        public static async Task<IEnumerable<Species>> GetSpeciesAsync(this People person, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Species>(person.species);
        }

        public static async Task<IEnumerable<Starship>> GetStarshipsAsync(this People person, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Starship>(person.starships);
        }

        public static async Task<IEnumerable<Vehicle>> GetVehiclesAsync(this People person, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Vehicle>(person.vehicles);
        }

        public static async Task<IEnumerable<Film>> GetFilmsAsync(this People person, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Film>(person.films);
        }
    }
}