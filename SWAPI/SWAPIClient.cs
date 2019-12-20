using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SWAPI.Models;

namespace SWAPI
{
    public class SWAPIClient
    {
        // Best practices state to reuse HTTP clients.
        // Con: DNS changes aren't respected until app is restarted.
        private readonly HttpClient client = new HttpClient();

        public SWAPIClient()
        {
            client.BaseAddress = new Uri(@"https://swapi.co/api/");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        // Retrieve data from the API for the given URL
        public async Task<T> GetAsync<T>(string url)
        {
            T retValue = default(T);

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsStringAsync();
            retValue = JsonConvert.DeserializeObject<T>(responseResult);

            return retValue;
        }

        // Recursively retrieves all pages for a given data type (People, Starship, etc)
        public async Task<IEnumerable<T>> GetAllAsync<T>(string type, int page = 1, IEnumerable<T> fullList = null)
        {
            var url = $"{type}/?page={page}";
            var entryList = await GetAsync<EntryList<T>>(url);
            var currentList = entryList.results;

            if (entryList.hasNext)
            {
                if (fullList is null)
                {
                    fullList = new List<T>();
                }

                var newEntry = await GetAllAsync<T>(type, ++page, fullList);
                var newList = currentList.Concat(newEntry);
                return newList;
            }

            return currentList;
        }

        // Retrieve data from the API given a list of URLs
        public async Task<IEnumerable<T>> GetListAsync<T>(IEnumerable<string> list)
        {
            var results = new List<T>();
            foreach(var url in list)
            {
                var result = await GetAsync<T>(url);
                results.Add(result);
            }

            return results;
        }

        public async Task<Starship> GetStarshipAsync(string id)
        {
            var url = $"starships/{id}";
            return await GetAsync<Starship>(url);
        }

        public async Task<IEnumerable<Starship>> GetAllStarshipAsync()
        {
            var type = "starships";
            return await GetAllAsync<Starship>(type);
        }

        public async Task<People> GetPeopleAsync(string id)
        {
            var url = $"people/{id}";
            return await GetAsync<People>(url);
        }

        public async Task<IEnumerable<People>> GetAllPeopleAsync()
        {
            var type = "people";
            return await GetAllAsync<People>(type);
        }
    }
}
