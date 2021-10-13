using System;
namespace Adapter
{
    class MoveEast : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("I'm going east.");
            if(currentTime <= 12)
            {
                Console.WriteLine("Wear sunglasses!");
            }
        }
    }
}
