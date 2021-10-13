namespace Zad2
{
    partial class Program
    {
        public class Civil : Inhabitant
        {

            public override string ToString()
            {
                return $"I'm {type}! I can't fight.";
            }


            public Civil()
            {
                type = "civil";
                foodRation = 2;
            }
        }
    }
}
