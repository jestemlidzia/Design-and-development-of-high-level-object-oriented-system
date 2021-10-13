namespace LAB05_IceCreamFactory
{
    class Sorbet : Icecream
    {
        public Sorbet(int price_, string taste_) : base(price_, taste_){ }
        public override string ToString()
        {
            string txt = $"{taste} sorbet. Cost: {price}$.";
            return txt;
        }
    }
}
