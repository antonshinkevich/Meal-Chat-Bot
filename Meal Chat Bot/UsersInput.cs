using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Channels;
using Meal_Chat_Bot.Models.Enums;
using Meal_Chat_Bot.Models.Meal;

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
                if (int.TryParse(Console.ReadLine(), out int numb))
                {
                    if (numb >= 0 && numb < array.Length)
                    {
                        index = numb;
                        break;
                    }
                }

                else
                    Console.WriteLine("Error. Input number");
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
            Console.WriteLine("Please select pizza type. '3' for print all menu");
            ListConsoleOutput(EnumToArray<PizzaType>(typeof(PizzaType)));
            Console.WriteLine("3) All pizzas");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index <= 3)
                {
                    if (index == 3)
                        return null;

                    return EnumToArray<PizzaType>(typeof(PizzaType))[index];
                }

                Console.WriteLine("Input incorrect. Please repeat");
            }
        }

        private static void ListConsoleOutput<T>(T[] array) where T : Enum
        {
            for (var i = 0; i < array.Length; i++)
                Console.WriteLine($"{i}) {array[i]}");
        }

        internal static string StringInput(string print)
        {
            Console.WriteLine(print);
            var input = Console.ReadLine();

            while (input == null)
            {
                Console.WriteLine($"String is empty. {print}");
                input = Console.ReadLine();
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
            Console.WriteLine("Please enter the number of pizza you want to add to the order", Console.ForegroundColor = ConsoleColor.White);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= pizzas.Length)
                    break;

                Console.WriteLine("Not correct. Try again");
            }

            //Pizza size select
            Console.WriteLine("You need a 'L'arge pizza or 'S'tandard?\r\n" +
                              "Input 'L' or 'S'.");

            do
            {
                var sizeSelect = char.ToUpper(Convert.ToChar(Console.ReadLine() ?? string.Empty));
                if (sizeSelect == 'S' || sizeSelect == 'L')
                {
                    return sizeSelect == 'S' ? pizzas[index * 2 - 2] : pizzas[index * 2 - 1];
                }

                Console.WriteLine("Not correct. Try again");
            } while (true);
        }

        internal static int PizzaCountInput()
        {
            Console.WriteLine("How many pizzas to order?");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int count) && count > 0 && count < 15)
                    return count;

                Console.WriteLine("Not correct input");
            }
        }

        internal static bool YesOrNo()
        {
            do
            {
                Console.WriteLine("Continue choosing pizza?");
                var sizeSelect = char.ToUpper(Convert.ToChar(Console.ReadLine() ?? string.Empty));
                if (sizeSelect == 'Y' || sizeSelect == 'N')
                    return sizeSelect == 'Y';

                Console.WriteLine("Not correct. Try again");
            } while (true);
        }
    }
}
