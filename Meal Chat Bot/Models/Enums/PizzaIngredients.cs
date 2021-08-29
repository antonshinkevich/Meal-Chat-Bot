using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Meal_Chat_Bot.Models.Enums
{
    public class PizzaIngredients
    {
        public static PizzaIngredients Ham { get; } = new PizzaIngredients("ветчина в/к");
        public static PizzaIngredients Brisket { get; } = new PizzaIngredients("грудинка в/к");
        public static PizzaIngredients Salami { get; } = new PizzaIngredients("колбаса салями");
        public static PizzaIngredients Chicken { get; } = new PizzaIngredients("филе курицы");
        public static PizzaIngredients Salmon { get; } = new PizzaIngredients("филе лосося");
        public static PizzaIngredients FreshCucumbers { get; } = new PizzaIngredients("огурцы свежие");
        public static PizzaIngredients SaltedCucumbers { get; } = new PizzaIngredients("огурцы консервированные");
        public static PizzaIngredients Tomato { get; } = new PizzaIngredients("томаты свежие");
        public static PizzaIngredients BellPepper { get; } = new PizzaIngredients("перец сладкий");
        public static PizzaIngredients Salad { get; } = new PizzaIngredients("салат свежий");
        public static PizzaIngredients Onion { get; } = new PizzaIngredients("лук репчатый");
        public static PizzaIngredients Leek { get; } = new PizzaIngredients("лук-порей");
        public static PizzaIngredients Mozzarella { get; } = new PizzaIngredients("сыр Моцарелла");
        public static PizzaIngredients HardCheese { get; } = new PizzaIngredients("сыр твердый");
        public static PizzaIngredients Spicy { get; } = new PizzaIngredients("специи для пиццы");
        public static PizzaIngredients Oil { get; } = new PizzaIngredients("масло чесночное");

        private static int _id;

        public int Id { get; set; }
        public string Name { get; set; }

        public PizzaIngredients(string name)
        {
            Id = _id++;
            Name = name;
        }
    }
}
