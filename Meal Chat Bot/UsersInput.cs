using System;
using System.Collections.Generic;
using System.Text;
using static Meal_Chat_Bot.Models.Enums.City;

namespace Meal_Chat_Bot
{
    static class UsersInput
    {
        internal static Cities CityInput()
        {
            Console.WriteLine("Привет, друг! Это бот скорой пиццы! Выбери город в котором находишься");
            return Cities.Minsk;
        }
    }
}
