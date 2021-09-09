using Meal_Chat_Bot.Models;

namespace Meal_Chat_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User
            {
                Name = UsersInput.StringInput(),
            };
        }
    }
}
