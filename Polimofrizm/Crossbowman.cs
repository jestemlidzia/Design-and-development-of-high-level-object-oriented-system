namespace Zad2
{
    partial class Program
    {
        public class Crossbowman : Defender
        {
            public override string ReadyToFight()
            {
                return $"I'm ready to fight! I've got my crossbow!";
            }

            public override string ToString()
            {
                return $"I'm {type}!";
            }

            public Crossbowman()
            {
                type = "crossbowman";
                foodRation = 5;
            }
    }
    }
}
