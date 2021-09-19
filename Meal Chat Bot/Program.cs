using System;
using System.Collections.Generic;
using Meal_Chat_Bot.Models;
using Meal_Chat_Bot.Models.Enums;
using Meal_Chat_Bot.Models.Filter;
using Meal_Chat_Bot.Models.Meal;
using static Meal_Chat_Bot.UsersInput;

namespace Meal_Chat_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            //var menu = PizzaMenuList.GetMenu();
            var menu = DataExport.ExportToJson();
            Console.WriteLine("Hi friend! It's Fast_Pizza bot. Please select your city");

            var user1 = new User
            {
                City = EnumItemSelection<City>(),
                Name = StringInput("Please enter your name")
            };

            Console.WriteLine($"We welcome you {user1.Name}! " +
                                "What pizza do you want? " +
                                "We will print our menu of pizzas");
            
            var pFilter = new PizzaFilter();

            var selectedPizzaType = SelectType();

            IEnumerable<Pizza> userMenu = menu;

            if (selectedPizzaType != null)
            {
                userMenu = pFilter.Filter(menu,
                    new Specification<Pizza>.AndSpecification<Pizza>(
                        new Specification<Pizza>.PizzaTypeSpecification(
                            selectedPizzaType.Value)));
            }

            Pizza.PizzaPrint(userMenu);
            var position = PizzaSelect(userMenu);
            user1.UserBasket.AddPosition(position, 1);
            user1.Email = StringInput("Input your Email address");
        }
    }
}
