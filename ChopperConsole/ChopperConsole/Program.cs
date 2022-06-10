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

            var hero = Hero.FromJson(FileReader.ReadUrl("https://raw.githubusercontent.com/rip333/Chopper/main/playable-heroes/ninja/ninja-hero.json"));
            
            Console.WriteLine("D for draw.  S for shuffle.  Q for quit.");
            Console.WriteLine("");

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
                        Console.WriteLine(hero.DrawCard());
                        break;
                    case 's':
                        Console.WriteLine("Shuffling..");
                        hero.Shuffle();
                        break;
                }
            }

        }
    }
}