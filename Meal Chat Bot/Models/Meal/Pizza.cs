using System;
using System.Collections.Generic;
using System.Text;
using Meal_Chat_Bot.Models.Enums;

namespace Meal_Chat_Bot.Models.Meal
{
    class Pizza : Meal
    {
        public PizzaType.TypeOfPizza TypeP { get; set; }
        public PizzaSize.Size Size { get; set; }
        public PizzaIngredients.Ingredients[] Ingredients { get; set; }
        public Sauce.TastySauce Sauce { get; set; }
    }
}
