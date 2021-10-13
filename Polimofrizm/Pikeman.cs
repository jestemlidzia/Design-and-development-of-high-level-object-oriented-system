namespace Zad2
{
    partial class Program
    {
        public class Pikeman : Defender
        {
            public override string ReadyToFight()
            {
                return $"I'm ready to fight! Look at my pike!";
            }

            public override string ToString()
            {
                return $"I belong to {type}!";
            }

            public Pikeman()
            {
                type = "pikeman";
                foodRation = 4;
            }
        }
    }
}
