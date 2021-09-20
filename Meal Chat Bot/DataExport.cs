using System.IO;
using System.Threading.Tasks;
using Meal_Chat_Bot.Models.Meal;
using Newtonsoft.Json;
using static Meal_Chat_Bot.Models.Enums.PizzaIngredients;
using static Meal_Chat_Bot.Models.Enums.PizzaSize;
using static Meal_Chat_Bot.Models.Enums.PizzaType;
using static Meal_Chat_Bot.Models.Enums.Sauce;

namespace Meal_Chat_Bot
{
    static class DataExport
    {
        internal static void ExportToJson()
        {
            Pizza[] pizzaArray =
            {
                new Pizza()
                {
                    Name = "Carbonara",
                    Price = 8.99M,
                    Weight = 430,
                    PizzaType = Meat,
                    PizzaSize = Standard,
                    Sauce = Carbonara,
                    Ingredients = new[] { Brisket, Tomato, Mozzarella, HardCheese, Spicy, Oil }
                },
                new Pizza()
                {
                    Name = "Carbonara",
                    Price = 14.99M,
                    Weight = 860,
                    PizzaType = Meat,
                    PizzaSize = Large,
                    Sauce = Carbonara,
                    Ingredients = new[] { Brisket, Tomato, Mozzarella, HardCheese, Spicy, Oil }
                },
                new Pizza()
                {
                    Name = "Pepperoni",
                    Price = 8.99M,
                    Weight = 380,
                    PizzaType = Meat,
                    PizzaSize = Standard,
                    Sauce = null,
                    Ingredients = new[] { Mozzarella, Salami, Oil, Spicy }
                },
                new Pizza()
                {
                    Name = "Pepperoni",
                    Price = 14.99M,
                    Weight = 760,
                    PizzaType = Meat,
                    PizzaSize = Large,
                    Sauce = null,
                    Ingredients = new[] { Mozzarella, Salami, Oil, Spicy }
                },
                new Pizza()
                {
                    Name = "Pizza with Ham and Salami",
                    Price = 8.99M,
                    Weight = 420,
                    PizzaType = Meat,
                    PizzaSize = Standard,
                    Sauce = Geneva,
                    Ingredients = new[] { Ham, Salami, Mozzarella, Oil, Spicy }
                },
                new Pizza()
                {
                    Name = "Pizza with Ham and Salami",
                    Price = 14.99M,
                    Weight = 840,
                    PizzaType = Meat,
                    PizzaSize = Large,
                    Sauce = Geneva,
                    Ingredients = new[] { Ham, Salami, Mozzarella, Oil, Spicy }
                },
                new Pizza()
                {
                    Name = "Village",
                    Price = 8.99M,
                    Weight = 460,
                    PizzaType = Meat,
                    PizzaSize = Standard,
                    Sauce = null,
                    Ingredients = new[] { Mozzarella, Ham, Brisket, SaltedCucumbers, Onion }
                },
                new Pizza()
                {
                    Name = "Village",
                    Price = 14.99M,
                    Weight = 920,
                    PizzaType = Meat,
                    PizzaSize = Large,
                    Sauce = null,
                    Ingredients = new[] { Mozzarella, Ham, Brisket, SaltedCucumbers, Onion }
                },
                new Pizza()
                {
                    Name = "Mama Mia",
                    Price = 8.99M,
                    Weight = 580,
                    PizzaType = Meat,
                    PizzaSize = Standard,
                    Sauce = Picante,
                    Ingredients = new[] { Ham, Salami, Mushrooms, SaltedCucumbers, Tomato, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "Mama Mia",
                    Price = 14.99M,
                    Weight = 1160,
                    PizzaType = Meat,
                    PizzaSize = Large,
                    Sauce = Picante,
                    Ingredients = new[] { Ham, Salami, Mushrooms, SaltedCucumbers, Tomato, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "Vegetable",
                    Price = 7.99M,
                    Weight = 550,
                    PizzaType = Vegan,
                    PizzaSize = Standard,
                    Sauce = Picante,
                    Ingredients = new[] { Salad, BellPepper, Tomato, FreshCucumbers, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "Vegetable",
                    Price = 11.99M,
                    Weight = 1100,
                    PizzaType = Vegan,
                    PizzaSize = Large,
                    Sauce = Picante,
                    Ingredients = new[] { Salad, BellPepper, Tomato, FreshCucumbers, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "With Fish and Tomatoes",
                    Price = 14.99M,
                    Weight = 480,
                    PizzaType = Fish,
                    PizzaSize = Standard,
                    Sauce = Picante,
                    Ingredients = new[] { Salmon, Tomato, Leek, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "With Fish and Tomatoes",
                    Price = 24.99M,
                    Weight = 960,
                    PizzaType = Fish,
                    PizzaSize = Large,
                    Sauce = Picante,
                    Ingredients = new[] { Salmon, Tomato, Leek, Mozzarella, Oil }
                },
                new Pizza()
                {
                    Name = "BBQ Chicken",
                    Price = 8.99M,
                    Weight = 550,
                    PizzaType = Meat,
                    PizzaSize = Standard,
                    Sauce = Barbecue,
                    Ingredients = new[] { Chicken, Mozzarella, Brisket, Tomato, Onion }
                },
                new Pizza()
                {
                    Name = "BBQ Chicken",
                    Price = 14.99M,
                    Weight = 1100,
                    PizzaType = Meat,
                    PizzaSize = Large,
                    Sauce = Barbecue,
                    Ingredients = new[] { Chicken, Mozzarella, Brisket, Tomato, Onion }
                }
            };

            string json = JsonConvert.SerializeObject(pizzaArray, Formatting.Indented);
            FileSystem.WriteText(json);
        }
    }
}
