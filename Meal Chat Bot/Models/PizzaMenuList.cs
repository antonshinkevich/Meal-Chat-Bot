using System.Collections.Generic;
using Meal_Chat_Bot.Models.Meal;
using Newtonsoft.Json;

namespace Meal_Chat_Bot.Models
{
    static class PizzaMenuList
    {
        internal static List<Pizza> GetMenu()
        {
            var json = JsonConvert.DeserializeObject<List<Pizza>>(FileSystem.ReadJson());
            return json;
        }
    }
}
