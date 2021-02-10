using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoFoodies.Models
{
    public class TempStorage
    {
        // This is where we will store the user suggestions
        private static List<UserRestaurant> userRestaurants = new List<UserRestaurant>();
        public static IEnumerable<UserRestaurant> UserRestaurants => userRestaurants;
        public static void AddRestaurant(UserRestaurant restaurant)
        {
            userRestaurants.Add(restaurant);
        }
    }
}
