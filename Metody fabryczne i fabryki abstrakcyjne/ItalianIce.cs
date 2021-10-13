namespace LAB05_IceCreamFactory
{
    class ItalianIce : Icecream
    {
        public bool waffle;
        public bool topping;

        public ItalianIce(int price_, string taste_, bool waffle_, bool topping_) : base(price_, taste_)
        {
            waffle = waffle_;
            topping = topping_;
        }
        public override string ToString()
        {
            string txt = $"{taste} italian ice cream";
            if (waffle) txt += " in waffle";
            if (topping) txt += " with topping";
            txt += $". Cost: {price}$.";
            return txt;
        }
    }
}
