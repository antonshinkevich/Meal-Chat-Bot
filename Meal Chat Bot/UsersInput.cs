using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static Meal_Chat_Bot.Models.Enums.City;

namespace Meal_Chat_Bot
{
    static class UsersInput
    {
        #region ItemSelect
        internal static T EnumItemSelection<T>() where T : Enum
        {
            var list = Enum.GetValues(typeof(T)).Cast<T>().ToList();
            var array = list as T[] ?? list.ToArray();
            ListConsoleOutput(array);

            var index = SelectIndex(array);
            return list[index];
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
        #endregion

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
