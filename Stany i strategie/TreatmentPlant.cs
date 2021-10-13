using System;
namespace StateTask
{
    class TreatmentPlant : State
    {
        public TreatmentPlant(Drop drop_) : base(drop_) { }
        public override string Info()
        {
            string txt = "Now I'm in the treatment plant.";
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
            Console.WriteLine("Incorrect!");
        }
        public override void Inflow() {
            Console.WriteLine("Incorrect!");
        }
        public override void Excretion() {
            Console.WriteLine("Incorrect!");
        }
        public override void Cleansing() {
            drop.changeState(new River(drop));
        }
    }
}
