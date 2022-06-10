using System.IO;

namespace ChopperConsole.Util
{
    public class FileReader
    {
        public static string ReadFile(string filePath)
        {
            using var r = new StreamReader(filePath);
            var text = r.ReadToEnd();
            return text;
        }
    }
}