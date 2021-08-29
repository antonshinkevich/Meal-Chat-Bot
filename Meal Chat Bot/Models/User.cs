using Meal_Chat_Bot.Models.Enums;

namespace Meal_Chat_Bot.Models
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public City.Cities City { get; set; }
    }
}
