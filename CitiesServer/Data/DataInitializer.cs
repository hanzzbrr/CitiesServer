using CitiesData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesServer.Data
{
    public class DataInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            if(context.Cities.Any())
            {
                return;
            }

            var cities = new City[]
            {
                new City { Name = "Yekaterinburg", FoundationDate = new DateTime(1723,11,18)},
                new City { Name = "Moscow", FoundationDate = new DateTime(1147, 4, 11)},
                new City { Name = "New York", FoundationDate = new DateTime(1624, 1,1)},
                new City { Name = "Saint Petersburg", FoundationDate = new DateTime(1703, 5, 27)},
                new City { Name = "Berlin", FoundationDate = new DateTime(1237, 1, 1)}
            };
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
