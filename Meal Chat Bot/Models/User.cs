using System;
using System.Linq;
using System.Reflection.Metadata;
using Meal_Chat_Bot.Models.Enums;

namespace Meal_Chat_Bot.Models
{
    class User
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                while (true)
                {
                    if (value.Length > 2 && value.Length < 11 && char.IsUpper(value.First()))
                        break;
                    else
                    {
                        Console.WriteLine("Please enter your name correctly");
                        value = UsersInput.StringInput();
                    }
                }

                _name = value;
            }
        }

        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime Time { get; set; }
        public City.Cities City { get; set; }
    }
}
