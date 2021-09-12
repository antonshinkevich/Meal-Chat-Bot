using System;
using System.IO;
using System.Threading.Tasks;

namespace Meal_Chat_Bot
{
    static class FileSystem
    {
        internal static string ReadJson()
        {
            var path = @"..\..\..\pizzas.json";
            var text = File.ReadAllText(path);
            return text;
        }
    }
}
