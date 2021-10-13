using System;
namespace Adapter
{
    class MoveWest : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("I'm going west");
            if (currentTime > 12)
            {
                Console.WriteLine("Wear sunglasses!");
            }
        }
    }
}
