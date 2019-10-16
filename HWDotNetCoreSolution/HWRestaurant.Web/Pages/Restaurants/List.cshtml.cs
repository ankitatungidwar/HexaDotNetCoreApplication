using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HWRestaurant.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HWRestaurant.Web.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        private readonly ILogger<ListModel> logger;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public string Meassage { get; set; }
        [TempData]
        public string Message2 { get; set; }
        public IEnumerable<HWRestaurant.Core.Restaurant> Restaurants { get; set; }
        public ListModel(IConfiguration config, IRestaurantData restaurantData, ILogger<ListModel> logger)
        {
            this.config = config;
            this.restaurantData = restaurantData;
            this.logger = logger;
        }
        public void OnGet()
        {
            logger.LogError("Something went wrong,Executing Hexaware ListModel");
            logger.LogInformation("Restaurants List");
            logger.LogWarning("Get some Restaurants");
            Meassage = config["Message"];
            // Restaurants = restaurantData.GetAll();
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);

        }
    }
}