using System;
using Meal_Chat_Bot.Models;
using Meal_Chat_Bot.Models.Enums;
using Meal_Chat_Bot.Models.Filter;
using Meal_Chat_Bot.Models.Meal;
using Meal_Chat_Bot.Models.Specification;
using static Meal_Chat_Bot.UsersInput;

namespace Meal_Chat_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = PizzaMenuList.GetMenu();

            Console.WriteLine("Hi friend! It's Fast_Pizza bot. Please select your city");
            var user1 = new User
            {
                City = EnumItemSelection<City>(),
                Name = StringInput("Please enter your name")
            };

            Console.WriteLine($"We welcome you {user1.Name}" +
                                "What pizza do you want? " +
                                "We will print our menu of pizzas");

            var pFilter = new PizzaFilter();

            var pizzaType = SelectType();

            if (pizzaType == null)
            {
                
            }
            else
            {
                var userMenu =
                    pFilter.Filter(menu, new Specification<Pizza>.PizzaTypeSpecification(pizzaType.Value));
            }

            user1.Email = StringInput("Input your Email address");
        }
    }
}
