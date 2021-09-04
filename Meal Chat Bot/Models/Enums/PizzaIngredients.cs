using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Meal_Chat_Bot.Models.Enums
{
    public class PizzaIngredients
    {
        public enum Ingredients
        {
            [Description("ветчина в/к")]
            Ham,
            [Description("грудинка в/к")]
            Brisket,
            [Description("колбаса салями")]
            Salami,
            [Description("филе курицы")]
            Chicken,
            [Description("филе лосося")]
            Salmon,
            [Description("огурцы свежие")]
            FreshCucumbers,
            [Description("огурцы консервированные")]
            SaltedCucumbers,
            [Description("томаты свежие")]
            Tomato,
            [Description("перец сладкий")]
            BellPepper,
            [Description("салат свежий")]
            Salad,
            [Description("лук репчатый")]
            Onion,
            [Description("лук-порей")]
            Leek,
            [Description("сыр Моцарелла")]
            Mozzarella,
            [Description("сыр твердый")]
            HardCheese,
            [Description("специи для пиццы")]
            Spicy,
            [Description("масло чесночное")]
            Oil
        }
    }
}
