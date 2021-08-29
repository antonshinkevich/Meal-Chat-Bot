using System.Collections.Generic;

namespace Meal_Chat_Bot.Models
{
    class Order
    {
        private static List<Meal.Meal> _basketOrder = new List<Meal.Meal>();
        public static IEnumerable<Meal.Meal> OrderList => _basketOrder;

        public static void AddOrder(Meal.Meal orderUnit)
        {
            _basketOrder.Add(orderUnit);
        }
    }
}
