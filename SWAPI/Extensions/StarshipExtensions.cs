using System.Collections.Generic;
using System.Threading.Tasks;
using SWAPI.Models;

namespace SWAPI.Extensions
{
    public static class StarshipExtensions
    {
        public static async Task<IEnumerable<People>> GetPilotAsync(this Starship starship, SWAPIClient apiClient)
        {
            return await apiClient.GetListAsync<People>(starship.pilots);
        }
    }
}