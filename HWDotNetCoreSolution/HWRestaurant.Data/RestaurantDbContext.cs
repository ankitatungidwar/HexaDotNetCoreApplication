using HWRestaurant.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWRestaurant.Data
{
    public class RestaurantDbContext: DbContext 
    {
        public RestaurantDbContext(
            DbContextOptions<RestaurantDbContext> options)
            :base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
