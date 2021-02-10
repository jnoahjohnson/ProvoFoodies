using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoFoodies.Models
{
    public class UserRestaurant
    {
        // Props for a restaurant that the user submits
        [Required, Display(Name="User Name")]
        public string UserName { get; set; }
        [Required, Display(Name="Restaurant Name")]
        public string RestaurantName { get; set; }
        [Display(Name="Favorite Dish")]
        public string? FavoriteDish { get; set; }
        [Required, RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Please enter a valid phone number"), Display(Name="Phone Number")]
        public string PhoneNumber { get; set; }

    }
}
