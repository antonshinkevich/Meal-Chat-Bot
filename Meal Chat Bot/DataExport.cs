using System;
using System.Collections.Generic;
using System.IO;
using Meal_Chat_Bot.Models.Meal;
using Newtonsoft.Json;
using static Meal_Chat_Bot.Models.Enums.PizzaIngredients.Ingredients;
using static Meal_Chat_Bot.Models.Enums.PizzaSize.Size;
using static Meal_Chat_Bot.Models.Enums.PizzaType.TypeOfPizza;
using static Meal_Chat_Bot.Models.Enums.Sauce.TastySauce;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Meal_Chat_Bot
{
    static class DataExport
    {
        internal static async void ExportToJson()
        {
            Pizza[] PizzaArray =
            {
                new Pizza()
                {
                    Name = "Carbonara",
                    Price = 8.99M,
                    Weight = 430,
                    TypeP = Meat,
                    Size = Standard,
                    Sauce = Carbonara,
                    Ingredients = new[] { Brisket, Tomato, Mozzarella, HardCheese, Spicy, Oil }
                },
                new Pizza()
                {
                    Name = "Carbonara",
                    Price = 14.99M,
                    Weight = 860,
                    TypeP = Meat,
                    Size = Large,
                    Sauce = Carbonara,
                    Ingredients = new[] { Brisket, Tomato, Mozzarella, HardCheese, Spicy, Oil }
                },
                new Pizza()
                {
                    Name = "Pepperoni",
                    Price = 8.99M,
                    Weight = 380,
                    TypeP = Meat,
                    Size = Standard,
                    Sauce = null,
                    Ingredients = new[] { Mozzarella, Salami, Oil, Spicy }
                },
                new Pizza()
                {
                    Name = "Pepperoni",
                    Price = 14.99M,
                    Weight = 760,
                    TypeP = Meat,
                    Size = Large,
                    Sauce = null,
                    Ingredients = new[] { Mozzarella, Salami, Oil, Spicy }
                },
                new Pizza()
                {
                    Name = "Pizza with Ham and Salami",
                    Price = 8.99M,
                    Weight = 420,
                    TypeP = Meat,
                    Size = Standard,
                    Sauce = Geneva,
                    Ingredients = new[] { Ham, Salami, Mozzarella, Oil, Spicy }
                },
                new Pizza()
                {
                    Name = "Pizza with Ham and Salami",
                    Price = 14.99M,
                    Weight = 840,
                    TypeP = Meat,
                    Size = Large,
                    Sauce = Geneva,
                    Ingredients = new[] { Ham, Salami, Mozzarella, Oil, Spicy }
                },
                new Pizza()
                {
                    Name = "Village",
                    Price = 8.99M,
                    Weight = 460,
                    TypeP = Meat,
                    Size = Standard,
                    Sauce = null,
                    Ingredients = new[] { Mozzarella, Ham, Brisket, SaltedCucumbers, Onion }
                },
                new Pizza()
                {
                    Name = "Village",
                    Price = 14.99M,
                    Weight = 920,
                    TypeP = Meat,
                    Size = Large,
                    Sauce = null,
                    Ingredients = new[] { Mozzarella, Ham, Brisket, SaltedCucumbers, Onion }
                },
                new Pizza()
                {
                    Name = "Mama Mia",
                    Price = 8.99M,
                    Weight = 580,
                    TypeP = Meat,
                    Size = Standard,
                    Sauce = Picante,
                    Ingredients = new[] { Ham, Salami, Mushrooms, SaltedCucumbers, Tomato, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "Mama Mia",
                    Price = 14.99M,
                    Weight = 1160,
                    TypeP = Meat,
                    Size = Large,
                    Sauce = Picante,
                    Ingredients = new[] { Ham, Salami, Mushrooms, SaltedCucumbers, Tomato, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "Vegetable",
                    Price = 7.99M,
                    Weight = 550,
                    TypeP = Vegan,
                    Size = Standard,
                    Sauce = Picante,
                    Ingredients = new[] { Salad, BellPepper, Tomato, FreshCucumbers, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "Vegetable",
                    Price = 11.99M,
                    Weight = 1100,
                    TypeP = Vegan,
                    Size = Large,
                    Sauce = Picante,
                    Ingredients = new[] { Salad, BellPepper, Tomato, FreshCucumbers, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "With Fish and Tomatoes",
                    Price = 14.99M,
                    Weight = 480,
                    TypeP = Fish,
                    Size = Standard,
                    Sauce = Picante,
                    Ingredients = new[] { Salmon, Tomato, Leek, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "With Fish and Tomatoes",
                    Price = 24.99M,
                    Weight = 960,
                    TypeP = Fish,
                    Size = Large,
                    Sauce = Picante,
                    Ingredients = new[] { Salmon, Tomato, Leek, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "BBQ Chicken",
                    Price = 8.99M,
                    Weight = 550,
                    TypeP = Meat,
                    Size = Standard,
                    Sauce = Barbecue,
                    Ingredients = new[] { Chicken, Mozzarella, Brisket, Tomato, Onion }
                },
                new Pizza()
                {
                    Name = "BBQ Chicken",
                    Price = 14.99M,
                    Weight = 1100,
                    TypeP = Meat,
                    Size = Large,
                    Sauce = Barbecue,
                    Ingredients = new[] { Chicken, Mozzarella, Brisket, Tomato, Onion }
                }
            };

            string path = @"D:\pizzas.json";
            string json = JsonConvert.SerializeObject(PizzaArray, Formatting.Indented);
            await File.WriteAllTextAsync(path, json);
        }
    }
}
