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

        public Card()
        {
        }

        public Card(string nameIn, string descriptionIn, string frontImageUrlIn)
        {
            name = nameIn;
            description = descriptionIn;
            frontImageUrl = frontImageUrlIn;
            copies = 1;
        }
        public string GetText()
        {
            return (name + "\n " + description);
        }
    }

    public class Hero
    {
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string health { get; set; }
        public string attack { get; set; }
        public string move { get; set; }
        public string defense { get; set; }
        public string backImageUrl { get; set; }
        public List<Card> deck { get; set; }
        
        public static Hero FromJson(string json) {
            var hero = JsonSerializer.Deserialize<Hero>(json);
            if (hero == null) return null;
            hero.HandleCopies();
            return hero;
        }

        public void HandleCopies()
        {
            var newCards = new List<Card>();
            foreach (var card in deck.Where(card => card.copies > 1))
            {
                for (var i = 1; i < card.copies; i++)
                {
                    var copy = new Card(card.name, card.description, card.frontImageUrl);
                    newCards.Add(copy);
                }

                card.copies = 1;
            }
            deck.AddRange(newCards);
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