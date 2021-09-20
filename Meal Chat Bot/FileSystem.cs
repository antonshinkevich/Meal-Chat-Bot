using System.IO;

namespace Meal_Chat_Bot
{
    static class FileSystem
    {
        internal static string ReadJson()
        {
            const string path = @"..\..\..\pizzas.json";
            using var sr = new StreamReader(path);
            var text = sr.ReadToEnd();
            return text;
        }

        internal static void WriteText(string writeText)
        {
            const string path = @"D:\pizzas.json";
            using var sw = new StreamWriter(path);
            sw.Write(writeText);
        }
    }
}
