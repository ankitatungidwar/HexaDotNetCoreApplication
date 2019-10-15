using HWRestaurant.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HWRestaurant.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id =1, Name="Domino's Pizza", Location="Maryland", Cuisine=CuisineType.Indian},
                new Restaurant{Id =2, Name="Cinnamon Club", Location="London", Cuisine=CuisineType.Italian},
                new Restaurant{Id =3, Name="La Costa", Location="California", Cuisine=CuisineType.Mexican}
            };

        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }
        public IEnumerable<Restaurant> GetAll()
        {
            //LINQ
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
