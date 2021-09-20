using System;
using System.Collections.Generic;
using System.Linq;
using Meal_Chat_Bot.Models.Enums;
using static System.Console;

namespace Meal_Chat_Bot.Models.Meal
{
    public class Pizza : Meal
    {
        public PizzaType PizzaType { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public PizzaIngredients[] Ingredients { get; set; }
        public Sauce? Sauce { get; set; }

        internal string TextIngredients => Ingredients.Aggregate("",
                (current, next) => $"{current}|{next}|");

        public override string ToString() => $"Name: {Name}. Type: {PizzaType} \r\nIngredients:";

        internal static void PizzaPrint(IEnumerable<Pizza> listPizzas)
        {
            if (listPizzas == null)
            {
                WriteLine("Selected Pizza list is empty");
            }
            else
            {
                int i = 2, count = 0;
                var price = new decimal[2];

                foreach (var pizza in listPizzas)
                {
                    price[i % 2] = pizza.Price;

                    if (i % 2 == 1)
                    {
                        count++;
                        WriteLine($"{count}) " + pizza.ToString(), ForegroundColor = ConsoleColor.White);
                        WriteLine(pizza.TextIngredients, ForegroundColor = ConsoleColor.DarkYellow);
                        Write("Price of a average pizza is ", ForegroundColor = ConsoleColor.White);
                        Write($"{price[0]}.\r\n", ForegroundColor = ConsoleColor.DarkGreen);
                        Write("For large pizza price is ", ForegroundColor = ConsoleColor.White);
                        Write($"{price[1]}.\r\n\r\n", ForegroundColor = ConsoleColor.DarkGreen);
                    }

                    i++;
                }
            }
        }
    }
}
