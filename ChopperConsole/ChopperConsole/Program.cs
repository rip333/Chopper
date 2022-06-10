using System;
using ChopperConsole.Util;

namespace ChopperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Chopper!");

            FileReader.ReadFile("https://github.com/rip333/Chopper/blob/main/playable-heroes/ninja/ninja-hero.json");
        }
    }
}