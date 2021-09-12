using System;
using System.Collections.Generic;
using Meal_Chat_Bot.Models.Enums;

namespace Meal_Chat_Bot.Models.Meal
{
    public class Pizza : Meal
    {
        public PizzaType PizzaType { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public PizzaIngredients[] Ingredients { get; set; }
        public Sauce? Sauce { get; set; }

        internal static void PizzaPrint(IEnumerable<Pizza> listPizzas)
        {
            int i = 2;
            foreach (var pizza in listPizzas)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{pizza}");
                }

                i++;
            }
        }
    }
}
