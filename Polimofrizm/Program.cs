using System;
using System.Collections.Generic;

namespace Zad2
{
    partial class Program
    {
        static void Main(string[] args)
        {

            List<Crossbowman> crossbowmen = new List<Crossbowman>();
            crossbowmen.Add(new Crossbowman());
            crossbowmen.Add(new Crossbowman());
            crossbowmen.Add(new Crossbowman());

            List<Defender> defenders = new List<Defender>();
            defenders.Add(new Crossbowman());
            defenders.Add(new Pikeman());
            defenders.Add(new Crossbowman());
            defenders.Add(new Pikeman());

            List<Inhabitant> inhabitants = new List<Inhabitant>();
            inhabitants.Add(new Crossbowman());
            inhabitants.Add(new Pikeman());
            inhabitants.Add(new Civil());
            inhabitants.Add(new Crossbowman());
            inhabitants.Add(new Civil());

            foreach (Crossbowman cro in crossbowmen) {
                Console.WriteLine(cro.ReadyToFight());
            }
            Console.WriteLine("\n");

            foreach (Defender def in defenders)
            {
                Console.WriteLine(def.ReadyToFight());
            }
            Console.WriteLine("\n");

            foreach (Inhabitant inh in inhabitants)
            {
                Console.WriteLine(inh);
                Console.WriteLine($"Food ration: {inh.Eat()}.");
            }
        }
    }
}
