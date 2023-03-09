using Humanizer;
using static Humanizer.In;
using static Inventory_Management_System.Models.Registration;
using System.Net;

namespace Inventory_Management_System.Models
{
    public class Registration
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public UserPreferences Preferences { get; set; }
     
        public class UserPreferences
        {
            public string FavoriteColor { get; set; }
            public string FavoriteFood { get; set; }
        }


    }
}
