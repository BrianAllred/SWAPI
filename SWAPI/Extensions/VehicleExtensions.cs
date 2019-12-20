using System.Collections.Generic;
using System.Threading.Tasks;
using SWAPI.Models;

namespace SWAPI.Extensions
{
    public static class VehicleExtensions
    {
        public static async Task<IEnumerable<People>> GetPilotsAsync(this Vehicle vehicle, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<People>(vehicle.pilots);
        }

        public static async Task<IEnumerable<Film>> GetFilmsAsync(this Vehicle vehicle, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<Film>(vehicle.films);
        }
    }
}