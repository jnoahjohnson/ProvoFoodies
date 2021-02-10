using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoFoodies.Models
{
    public class Restaurant
    {
        // Initialize the restaurant with a rank
        public Restaurant(int rank)
        {
            Rank = rank;
        }

        // Restaurant properties

        [Required]
        public int Rank { get; }
        [Required]
        public string Name  { get; set; }

        public string? FavoriteDish { get; set; }

        [Required]
        public string Address { get; set; } = "No address";

        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Please enter a valid phone number")]
        public string? PhoneNumber { get; set; }
        public string? Website { get; set; } = "Coming soon...";

     
        public static Restaurant[] GetRestaurants()
        {
            // Create top default restaurants
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Two Jack\'s Pizza",
                FavoriteDish = "Pepperoni Sausage Pizza",
                Address = "80 W Center St, Provo, UT 84601",
                PhoneNumber = "801-377-4747",
                Website = "https://www.twojackspizza.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Silver Dish Thai Cuisine",
                FavoriteDish = "Massaman Curry",
                Address = "278 W Center St, Provo, UT 84601",
                PhoneNumber = "801-373-9540",
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Rodizio",
                FavoriteDish = "Picanha",
                Address = "4801 N University Ave Ste 710, Provo, UT 84604",
                PhoneNumber = "801-374-0100",
                Website = "https://www.rodiziogrill.com"

            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "Magleby's Fresh",
                FavoriteDish = "Maple Bacon",
                Address = "3362 N University Ave, Provo, UT 84604",
                PhoneNumber = "801-852-8620",
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "180 Tacos",
                FavoriteDish = null,
                Address = "3368 N University Ave, Provo, UT 84604",
                PhoneNumber = "801-356-8226",
                Website = "https://www.180tacos.com"

            };

            // Return an array of restaurants
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
