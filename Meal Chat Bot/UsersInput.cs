using System;
using System.Linq;
using Meal_Chat_Bot.Models.Enums;

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

        private static void PizzaPrint<T>() where T : Enum
        {
            ListConsoleOutput(EnumToArray<T>(typeof(PizzaType)));
        }

        private static T[] EnumToArray<T>(Type enumType)
        {
            var list = Enum.GetValues(enumType).Cast<T>().ToList();
            return list as T[] ?? list.ToArray();
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
