using System;
namespace Adapter
{
    class MoveNoth : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("I'm going north");
        }
    }
}
