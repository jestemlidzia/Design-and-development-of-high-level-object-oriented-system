namespace Zad2
{
    partial class Program
    {
        public class Defender : Inhabitant
        {
            public virtual string ReadyToFight()
            {
                return "Defender ready to fight!";
            }

            public override string ToString()
            {
                return $"I'm {type}! I will fight.";
            }

            public Defender()
            {
                type = "defender";
                foodRation = 3;
            }

        }
    }
}
