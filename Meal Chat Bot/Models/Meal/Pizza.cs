using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Meal_Chat_Bot.Models.Enums;

namespace Meal_Chat_Bot.Models.Meal
{
    public class Pizza : Meal
    {
        public PizzaType PizzaType { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public PizzaIngredients[] Ingredients { get; set; }
        public Sauce? Sauce { get; set; }

        public override string ToString()
        {
            var ingredients = Ingredients.Aggregate(
                "",
                (current, next) => current + "| " + next);

            return $"Name: {Name}. Type: {PizzaType} Ingredients: \r\n" +
                   $"{ingredients}";
        }

        internal static void PizzaPrint(IEnumerable<Pizza> listPizzas)
        {
            if (listPizzas == null)
            {
                Console.WriteLine("Selected Pizza list is empty");
            }
            else
            {
                int i = 1;

                foreach (var pizza in listPizzas)
                {
                    var price = new decimal[2];
                    price[i % 2] = pizza.Price;

                    if (i % 2 == 0)
                    {
                        Console.WriteLine(pizza.ToString());
                        Console.WriteLine($"Price of a average pizza is {price[0]}. For large pizza price is {price[1]}");
                    }

                    i++;
                }
            }
        }
    }
}
