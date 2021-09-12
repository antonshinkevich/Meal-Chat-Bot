using Meal_Chat_Bot.Models.Enums;

namespace Meal_Chat_Bot.Models.Meal
{
    public class Pizza : Meal
    {
        public PizzaType PizzaType { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public PizzaIngredients[] Ingredients { get; set; }
        public Sauce? Sauce { get; set; }
    }
}
