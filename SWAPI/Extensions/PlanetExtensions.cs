using System.Collections.Generic;
using System.Threading.Tasks;
using SWAPI.Models;

namespace SWAPI.Extensions
{
    public static class PlanetExtensions
    {
        public static async Task<IEnumerable<Film>> GetFilmsAsync(this Planet planet, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Film>(planet.films);
        }

        public static async Task<IEnumerable<People>> GetResidentsAsync(this Planet planet, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<People>(planet.residents);
        }
    }
}