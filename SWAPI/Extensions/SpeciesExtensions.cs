using System.Collections.Generic;
using System.Threading.Tasks;
using SWAPI.Models;

namespace SWAPI.Extensions
{
    public static class SpeciesExtensions
    {
        public static async Task<IEnumerable<People>> GetPeopleAsync(this Species species, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<People>(species.people);
        }

        public static async Task<IEnumerable<Film>> GetFilmsAsync(this Species species, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Film>(species.films);
        }
    }
}