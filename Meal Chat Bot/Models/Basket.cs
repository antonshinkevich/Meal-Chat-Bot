using System.Collections.Generic;
using Meal_Chat_Bot.Models.Meal;

namespace Meal_Chat_Bot.Models
{
    class Basket
    {
        private List<Position> _basketOrder;

        public Basket()
        {
            _basketOrder = new List<Position>();
        }

        public void AddPosition(Meal.Meal orderUnit, int counter)
        {
            var order = new Position()
            {
                Meal = orderUnit,
                Counter = counter,
            };

            _basketOrder.Add(order);
        }

        class Position
        {
            protected internal Meal.Meal Meal { get; set; }
            protected internal int Counter { get; set; }
        }
    }
}
