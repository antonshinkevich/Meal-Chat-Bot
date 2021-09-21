using System.Collections.Generic;
using Meal_Chat_Bot.Models.Meal;

namespace Meal_Chat_Bot.Models
{
    class Basket
    {
        public Basket()
        {
            BasketOrder = new List<Position>();
        }

        public List<Position> BasketOrder { get; }

        public void AddPosition(Meal.Meal orderUnit, int counter)
        {
            var order = new Position()
            {
                Meal = orderUnit,
                Counter = counter,
            };

            BasketOrder.Add(order);
        }

        internal class Position
        {
            protected internal Meal.Meal Meal { get; set; }
            protected internal int Counter { get; set; }
        }
    }
}
