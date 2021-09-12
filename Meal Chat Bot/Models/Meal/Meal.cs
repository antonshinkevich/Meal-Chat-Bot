using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Meal_Chat_Bot.Models.Meal
{
    public abstract class Meal
    {
        private static int _id;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }

        protected Meal()
        {
            Id = _id++;
        }
    }
}
