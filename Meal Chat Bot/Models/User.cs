using System;
using System.Linq;
using System.Text.RegularExpressions;
using Meal_Chat_Bot.Models.Enums;

namespace Meal_Chat_Bot.Models
{
    class User
    {
        private string _name;
        private string _email;
        //private Basket _basket;

        public string Name
        {
            get => _name;
            set
            {
                while (true)
                {
                    var letterFlag = value.All(char.IsLetter);

                    if (value.Length > 2 && value.Length < 11 && char.IsUpper(value.First()) && letterFlag)
                        break;
                    value = UsersInput.StringInput("Please enter your name correctly");
                }

                _name = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                const string regexEmailPattern = @".+@.+\..+";

                while (true)
                {
                    if (Regex.IsMatch(value, regexEmailPattern, RegexOptions.IgnoreCase))
                    {
                        Console.WriteLine("Ok! Email is correct");
                        break;
                    }

                    value = UsersInput.StringInput("Please enter your Email correctly");
                }

                _email = value;
            }
        }

        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime Time { get; set; }
        public City City { get; set; }
        //public Basket UserBasket { get => _basket};
        public Basket UserBasket { get; set; }

        public User()
        {
            UserBasket = new Basket();
        }
    }
}
