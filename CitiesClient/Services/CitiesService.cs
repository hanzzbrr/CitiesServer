using CitiesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CitiesClient.Services
{
    public class CitiesService : ICitiesService
    {
        private readonly HttpClient _httpClient;

        public CitiesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<City>> GetCities()
        {
            var value = await _httpClient.GetFromJsonAsync<City[]>("api/Cities/");
            return value;
        }
    }
}
