using System;
namespace StateTask
{
    class River : State
    {
        public River(Drop drop_) : base(drop_) { }
        public override string Info()
        {
            string txt = "Now I'm in the river.";
            return txt;
        }
        public override void Rainfall() {
            Console.WriteLine("Incorrect!");
        }
        public override void Respiration() {
            Console.WriteLine("Incorrect!");
        }
        public override void Drinking() {
            drop.changeState(new Animal(drop));
        }
        public override void Evaporation() {
            drop.changeState(new Cloud(drop));
        }
        public override void Inflow() {
            drop.changeState(new Ocean(drop));
        }
        public override void Excretion() {
            Console.WriteLine("Incorrect!");
        }
        public override void Cleansing() {
            Console.WriteLine("Incorrect!");
        }
    }
}
