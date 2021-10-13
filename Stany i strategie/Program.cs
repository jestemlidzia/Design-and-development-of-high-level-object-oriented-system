using System;

namespace StateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drop life circle.\n");

            Drop drop = new Drop();
            State state = new Cloud(drop);
            drop.changeState(state);


            Console.WriteLine(drop.GetStateInfo());

            drop.Rainfall();
            Console.WriteLine(drop.GetStateInfo());
            drop.Drinking();
            Console.WriteLine(drop.GetStateInfo());
            drop.Excretion();
            Console.WriteLine(drop.GetStateInfo());
            drop.Cleansing();
            Console.WriteLine(drop.GetStateInfo());
            drop.Evaporation();
            Console.WriteLine(drop.GetStateInfo());
            Console.WriteLine("\n");
            drop.Rainfall();
            Console.WriteLine(drop.GetStateInfo());
            drop.Inflow();
            Console.WriteLine(drop.GetStateInfo());
            drop.Evaporation();
            Console.WriteLine(drop.GetStateInfo());
            Console.WriteLine("\n");
            drop.Rainfall();
            Console.WriteLine(drop.GetStateInfo());
            drop.Respiration();
            Console.WriteLine(drop.GetStateInfo());
        }
    }
}
