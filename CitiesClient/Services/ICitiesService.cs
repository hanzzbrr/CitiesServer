using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiesData;

namespace CitiesClient.Services
{
    public interface ICitiesService
    {
        Task<IEnumerable<City>> GetCities();
    }
}
