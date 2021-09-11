using System;
using System.Linq;
using Meal_Chat_Bot.Models;
using Meal_Chat_Bot.Models.Enums;
using static Meal_Chat_Bot.UsersInput;

namespace Meal_Chat_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi friend! It's Fast_Pizza bot. Please select your city");
            var user1 = new User
            {
                City = EnumItemSelection<City.Cities>(),
                Name = StringInput("Please enter your name")
            };

            Console.WriteLine($"We welcome you {user1.Name}" +
                                "What pizza do you want? " +
                                "We will print our menu of pizzas");
            
            user1.Email = StringInput("Input your Email address");
        }
    }
}
