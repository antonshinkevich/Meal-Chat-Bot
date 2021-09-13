using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meal_Chat_Bot.Models.Meal;

namespace Meal_Chat_Bot.Models.Filter
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }

    public class PizzaFilter : IFilter<Pizza>
    {
        public IEnumerable<Pizza> Filter(IEnumerable<Pizza> items, Specification<Pizza> spec)
        {
            return items.Where(spec.IsSatisfied);
        }
    }
}
