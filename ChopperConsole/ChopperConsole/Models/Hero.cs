using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ChopperConsole.Models
{
    public class Card
    {
        public string name { get; set; }
        public string description { get; set; }
        public string frontImageUrl { get; set; }
        public int copies { get; set; }

        public string GetText()
        {
            return (name + "\n" + description);
        }
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

        public void Shuffle()
        {
            var rng = new Random();  
            var n = deck.Count;  
            while (n > 1) {  
                n--;  
                var k = rng.Next(n + 1);  
                (deck[k], deck[n]) = (deck[n], deck[k]);
            }  
        }

        public string DrawCard()
        {
            var card = deck.First();
            deck.RemoveAt(0);
            deck.Add(card);
            return card.GetText();
        }
    }
}