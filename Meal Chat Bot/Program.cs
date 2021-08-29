using System;
using System.IO;
using System.Text.Json;
using Meal_Chat_Bot.Models.Enums;
using Meal_Chat_Bot.Models.Meal;
//using Newtonsoft.Json;
using static Meal_Chat_Bot.Models.Enums.PizzaIngredients;
using static Meal_Chat_Bot.Models.Enums.PizzaSize.Size;
using static Meal_Chat_Bot.Models.Enums.PizzaType.TypeOfPizza;
using static Meal_Chat_Bot.Models.Enums.Sauce.TastySauce;

namespace Meal_Chat_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var carboaraAvg = new Pizza()
            {
                Name = "Карбонара",
                Price = 8.99M, 
                Weight = 430,
                TypeP = Meat,
                Size = Average,
                Sauce = Carbonara,
                IngredientsId = new[]{ Brisket.Id, Tomato.Id, Mozzarella.Id, HardCheese.Id, Spicy.Id, Oil.Id }
            };

            string path = @"d:\pizzas.json";
            string json = JsonSerializer.Serialize(carboaraAvg);
            File.WriteAllText(path, json);
            string jsonString = JsonSerializer.Serialize(carboaraAvg);
            Console.WriteLine(jsonString);
        }
    }
}
