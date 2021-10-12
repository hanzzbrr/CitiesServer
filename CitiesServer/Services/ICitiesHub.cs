using CitiesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesServer.Services
{
    public interface ICitiesHub
    {
        Task SendCityInfo(City city);
        Task CityHubMessage(string msg);
    }
}
