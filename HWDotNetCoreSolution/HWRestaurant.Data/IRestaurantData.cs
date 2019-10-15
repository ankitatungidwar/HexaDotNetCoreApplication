﻿using HWRestaurant.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWRestaurant.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetRestaurantsByName(string name); //services
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        int Commit();
        Restaurant Delete(int id);
        Restaurant Add(Restaurant newRestaurant);

    }
}
