using System;
using System.Collections.Generic;
using System.Linq;
using Meal_Chat_Bot.Models;
using Meal_Chat_Bot.Models.Enums;
using Meal_Chat_Bot.Models.Meal;
using static System.Console;

namespace Meal_Chat_Bot
{
    static class UsersInput
    {
        #region ItemSelect
        internal static T EnumItemSelection<T>() where T : Enum
        {
            var array = EnumToArray<T>(typeof(T));
            ListConsoleOutput(array);

            var index = SelectIndex(array);
            return array[index];
        }

        private static int SelectIndex<T>(T[] array)
        {
            int index;
            while (true)
            {
                if (int.TryParse(ReadLine(), out int numb))
                {
                    if (numb >= 0 && numb < array.Length)
                    {
                        index = numb;
                        break;
                    }
                }

                else
                    WriteLine("Error. Input number");
            }

            return index;
        }

        private static T[] EnumToArray<T>(Type enumType)
        {
            var list = Enum.GetValues(enumType).Cast<T>().ToList();
            return list as T[] ?? list.ToArray();
        }
        #endregion

        internal static PizzaType? SelectType()
        {
            WriteLine("Please select pizza type. '3' for print all menu");
            ListConsoleOutput(EnumToArray<PizzaType>(typeof(PizzaType)));
            WriteLine("3) All pizzas");
            while (true)
            {
                if (int.TryParse(ReadLine(), out int index) && index >= 0 && index <= 3)
                {
                    if (index == 3)
                        return null;

                    return EnumToArray<PizzaType>(typeof(PizzaType))[index];
                }

                WriteLine("Input incorrect. Please repeat");
            }
        }

        private static void ListConsoleOutput<T>(T[] array) where T : Enum
        {
            for (var i = 0; i < array.Length; i++)
                WriteLine($"{i}) {array[i]}");
        }

        internal static string StringInput(string print)
        {
            WriteLine(print, ForegroundColor = ConsoleColor.White);
            var input = ReadLine();

            while (input == null)
            {
                WriteLine($"String is empty. {print}", ForegroundColor = ConsoleColor.White);
                input = ReadLine();
            }

            return input;
        }

        /// <summary>
        /// Select pizza from input menu
        /// </summary>
        /// <param name="menu">Menu</param>
        /// <returns></returns>
        internal static Pizza PizzaSelect(IEnumerable<Pizza> menu)
        {
            int index;
            var pizzas = menu as Pizza[] ?? menu.ToArray();
            WriteLine("Please enter the number of pizza you want to add to the order", ForegroundColor = ConsoleColor.White);
            while (true)
            {
                if (int.TryParse(ReadLine(), out index) && index > 0 && index <= pizzas.Length)
                    break;

                WriteLine("Not correct. Try again");
            }

            //Pizza size select
            WriteLine("You need a 'L'arge pizza or 'S'tandard?\r\n" +
                              "Input 'L' or 'S'.");

            do
            {
                var sizeSelect = char.ToUpper(Convert.ToChar(ReadLine() ?? string.Empty));
                if (sizeSelect == 'S' || sizeSelect == 'L')
                {
                    return sizeSelect == 'S' ? pizzas[index * 2 - 2] : pizzas[index * 2 - 1];
                }

                WriteLine("Not correct. Try again");
            } while (true);
        }

        internal static int PizzaCountInput()
        {
            WriteLine("How many pizzas to order?");
            while (true)
            {
                if (int.TryParse(ReadLine(), out int count) && count > 0 && count < 15)
                    return count;

                WriteLine("Not correct input");
            }
        }

        internal static bool YesOrNo()
        {
            do
            {
                WriteLine("Continue choosing pizza? 'Y' or 'N'");
                var sizeSelect = char.ToUpper(Convert.ToChar(ReadLine() ?? string.Empty));
                if (sizeSelect == 'Y' || sizeSelect == 'N')
                    return sizeSelect == 'Y';

                WriteLine("Not correct. Try again");
            } while (true);
        }

        internal static void PrintCheck(Basket basket)
        {
            decimal checkAmount = 0;
            foreach (var position in basket.BasketOrder)
            {
                checkAmount += position.Counter * position.Meal.Price;
                Pizza pizza = position.Meal as Pizza;
                if (pizza != null)
                {
                    WriteLine(pizza.ToString());
                    WriteLine(pizza.TextIngredients);
                    WriteLine($"Size is {pizza.PizzaSize}. {position.Counter} pcs.");
                }
            }

            WriteLine("Your check amount: ");
            Write($"{checkAmount}\r\n", ForegroundColor = ConsoleColor.DarkGreen);
        }
    }
}
