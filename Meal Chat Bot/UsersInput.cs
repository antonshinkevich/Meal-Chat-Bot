using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
