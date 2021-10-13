using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Simulator simulator = new Simulator(11);
            simulator.Memorize();

        }
    }
}
