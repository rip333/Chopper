using System;
using ChopperConsole.Models;
using ChopperConsole.Util;

namespace ChopperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Chopper!");

            var ninja = Hero.FromJson(FileReader.ReadUrl("https://raw.githubusercontent.com/rip333/Chopper/main/playable-heroes/Ninja.json"));
            var knight =
                Hero.FromJson(
                    FileReader.ReadUrl(
                        "https://raw.githubusercontent.com/rip333/Chopper/main/playable-heroes/Knight.json"));
            
            Console.WriteLine("D for draw.  S for shuffle.  Q for quit.");
            Console.WriteLine("");
            Console.WriteLine("Shuffling..");
            ninja.Shuffle();
            knight.Shuffle();
            
            var playing = true;

            while (playing)
            {
                var input = Console.ReadKey();
                Console.WriteLine("");
                switch (input.KeyChar)
                {
                    case 'q':
                        playing = false;
                        break;
                    case 'd':
                        Console.WriteLine("Ninja: " + ninja.DrawCard());
                        Console.WriteLine("Ninja: " + ninja.DrawCard());
                        Console.WriteLine("...");
                        Console.WriteLine("Knight: " + knight.DrawCard());
                        Console.WriteLine("Knight: " + knight.DrawCard());
                        break;
                    case 's':
                        Console.WriteLine("Shuffling..");
                        ninja.Shuffle();
                        knight.Shuffle();
                        break;
                }
            }

        }
    }
}