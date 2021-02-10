using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvoFoodies.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoFoodies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Create a new list of strings
            List<string> restaurantList = new List<string>();

            // Iterate through all the restaurants
            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                // Create a new string for each restaurant and add it to the list
                restaurantList.Add($"#{r.Rank}) {r.Name} - Favorite Dish: {r.FavoriteDish ?? "It's all tasty!"} - Address: {r.Address} - Phone: {r.PhoneNumber ?? "No phone number"} - Website: {r.Website}");
            }

            return View(restaurantList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult ViewUserRestaurants()
        {
            return View(TempStorage.UserRestaurants.ToList());
        }

        [HttpGet]
        public IActionResult AddRestaurant()
        {
            return View();
        }

        // When the user posts a restaurant, check to see if it is valid and add it to temp storage if it is.
        [HttpPost]
        public IActionResult AddRestaurant(UserRestaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(restaurant);
                List<UserRestaurant> allRestaurants = TempStorage.UserRestaurants.ToList();
                return View("ViewUserRestaurants", allRestaurants);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
