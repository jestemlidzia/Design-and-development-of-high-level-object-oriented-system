using System;
namespace StateTask
{
    class Plant : State
    {
        public Plant(Drop drop_) : base(drop_) { }
        public override string Info()
        {
            string txt = "Now I'm in the plant.";
            return txt;
        }
        public override void Rainfall() {
            Console.WriteLine("Incorrect!");
        }
        public override void Respiration() {
            drop.changeState(new Cloud(drop));
        }
        public override void Drinking() {
            Console.WriteLine("Incorrect!");
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
