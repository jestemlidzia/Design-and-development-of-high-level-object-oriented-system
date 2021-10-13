namespace LAB05_IceCreamFactory
{
    class FruitIce : Icecream
    {
        public bool waffle;
        public string icing;

        public FruitIce(int price_, string taste_, bool waffle_, string icing_) : base(price_, taste_)
        {
            waffle = waffle_;
            icing = icing_;
        }
        public override string ToString()
        {
            string txt = $"{taste} fruit ice cream";
            if (waffle) txt += " in waffle";
            if (icing != "" && icing != "None") txt += $" with {icing}";
            txt += $". Cost: {price}$.";
            return txt;
        }
    }
}
