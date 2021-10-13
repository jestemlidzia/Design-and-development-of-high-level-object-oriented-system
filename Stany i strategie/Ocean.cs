using System;
namespace StateTask
{
    class Ocean : State
    {
        public Ocean(Drop drop_) : base(drop_) { }
        public override string Info()
        {
            string txt = "Now I'm in the ocean.";
            return txt;
        }
        public override void Rainfall() {
            Console.WriteLine("Incorrect!");
        }
        public override void Respiration() {
            Console.WriteLine("Incorrect!");
        }
        public override void Drinking() {
            Console.WriteLine("Incorrect!");
        }
        public override void Evaporation() {
            drop.changeState(new Cloud(drop));
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
