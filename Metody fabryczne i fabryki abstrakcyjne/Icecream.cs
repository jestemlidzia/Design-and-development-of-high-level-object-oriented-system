namespace LAB05_IceCreamFactory
{
    abstract class Icecream
    {
        public int price;
        public string taste;
        public Icecream(int price_, string taste_)
        {
            price = price_;
            taste = taste_;
        }
        
    }
}
