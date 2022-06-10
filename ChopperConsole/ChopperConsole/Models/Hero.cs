using System.Collections.Generic;
using System.Text.Json;

namespace ChopperConsole.Models
{
    public class Card
    {
        public string name { get; set; }
        public string description { get; set; }
        public string frontImageUrl { get; set; }
        public int copies { get; set; }
    }

    public class Hero
    {
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int health { get; set; }
        public string attack { get; set; }
        public string move { get; set; }
        public string defense { get; set; }
        public string backImageUrl { get; set; }
        public List<Card> deck { get; set; }
        
        public static Hero FromJson(string json) {
            return JsonSerializer.Deserialize<Hero>(json);
        }
    }
}