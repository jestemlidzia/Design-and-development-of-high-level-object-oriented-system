using System;
namespace StateTask
{
    class Well : State
    {
        public Well(Drop drop_) : base(drop_){}
        
        public override string Info()
        {
            string txt = "Now I'm in the well.";
            return txt;
        }
        public override void Rainfall() {
            Console.WriteLine("Incorrect!");
        }
        public override void Respiration() {
            Console.WriteLine("Incorrect!");
        }
        public override void Drinking() {

            drop.changeState(new Human(drop));
        }
        public override void Evaporation() {
            Console.WriteLine("Incorrect!");
        }
        public override void Inflow() {
            Console.WriteLine("Incorrect!");
        }
        public override void Excretion() {
            Console.WriteLine("Incorrect!");
        }
        public override void Cleansing() {
            Console.WriteLine("Incorrect!");
        }
    }
}
