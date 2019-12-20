using System.Threading.Tasks;
using SWAPI.Models;

namespace SWAPI.Extensions
{
    public static class EntryListExtensions
    {
        public static async Task<EntryList<T>> GetPrevious<T>(this EntryList<T> entryList, SWAPIClient apiClient)
        {
            return await apiClient.GetAsync<EntryList<T>>(entryList.previous);
        }

        public static async Task<EntryList<T>> GetNext<T>(this EntryList<T> entryList, SWAPIClient apiClient)
        {
            return await apiClient.GetAsync<EntryList<T>>(entryList.next);
        }
    }
}