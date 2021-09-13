using System.Linq;
using Meal_Chat_Bot.Models.Enums;
using Meal_Chat_Bot.Models.Meal;

namespace Meal_Chat_Bot.Models.Filter
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T p);

        public static Specification<T> operator &(
            Specification<T> first, Specification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }

        public class PizzaTypeSpecification : Specification<Pizza>
        {
            private PizzaType pType;

            public PizzaTypeSpecification(PizzaType pType)
            {
                this.pType = pType;
            }

            public override bool IsSatisfied(Pizza p)
            {
                return p.PizzaType == pType;
            }
        }

        public class PizzaSizeSpecification : Specification<Pizza>
        {
            private PizzaSize size;

            public PizzaSizeSpecification(PizzaSize size)
            {
                this.size = size;
            }

            public override bool IsSatisfied(Pizza p)
            {
                return p.PizzaSize == size;
            }
        }
        public abstract class CompositeSpecification<T> : Specification<T>
        {
            protected readonly Specification<T>[] items;

            protected CompositeSpecification(params Specification<T>[] items)
            {
                this.items = items;
            }
        }

        public class AndSpecification<T> : CompositeSpecification<T>
        {
            public AndSpecification(params Specification<T>[] items) : base(items)
            {
            }

            public override bool IsSatisfied(T t)
            {
                return items.All(i => i.IsSatisfied(t));
            }
        }
    }
}
