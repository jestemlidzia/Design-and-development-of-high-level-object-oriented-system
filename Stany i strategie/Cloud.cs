using System;
namespace StateTask
{
    class Cloud : State
    {
        public Cloud(Drop drop_) : base(drop_) { }
        public override string Info()
        {
            string txt = "Now I'm in the cloud.";
            return txt;
        }
        public override void Rainfall() {

        //    Random rnd = new Random();
        //    int temp = rnd.Next(1, 4);

               switch (drop.getCounter())
                {
                    case 0:
                        drop.changeState(new Well(drop));
                        break;
                    case 1:
                        drop.changeState(new River(drop));
                        break;
                    case 2:
                        drop.changeState(new Plant(drop));
                        break;
                }
           

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
            Console.WriteLine("Incorrect!");
        }
    }
}
