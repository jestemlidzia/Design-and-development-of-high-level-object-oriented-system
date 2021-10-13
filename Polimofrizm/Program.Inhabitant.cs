namespace Zad2
{
    partial class Program
    {
        public abstract class Inhabitant
        {
            protected int foodRation;
            protected string type;
            public int Eat()
            {
                return foodRation;
            }
        }
    }
}
