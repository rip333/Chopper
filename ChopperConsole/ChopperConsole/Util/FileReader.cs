using System.IO;
using System.Net;
using System.Threading.Tasks;

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

        public static string ReadUrl(string url)
        {
            using WebClient client = new WebClient();
            var text = client.DownloadString(url);
            return text;
        }
    }
}