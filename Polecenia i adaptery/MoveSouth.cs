using System;
namespace Adapter
{
    class MoveSouth : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("I'm going south");
        }
    }
}
