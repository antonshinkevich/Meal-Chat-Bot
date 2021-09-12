using System.ComponentModel;

namespace Meal_Chat_Bot.Models.Enums
{
    public enum PizzaIngredients
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
        Oil,
        [Description("шампиньоны свежие")]
        Mushrooms
    }
}
