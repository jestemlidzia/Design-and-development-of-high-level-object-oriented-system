namespace LAB05_IceCreamFactory
{
    class CreamIce : Icecream
    {
        public bool waffle;
        public string icing;
        public bool topping;

        public CreamIce(int price_, string taste_, bool waffle_, string icing_, bool topping_) : base(price_, taste_)
        {
            waffle = waffle_;
            icing = icing_;
            topping = topping_;
        }
        public override string ToString()
        {
            string txt = $"{taste} (cream) ice cream";
            if (waffle) txt += " in waffle";
            if (topping) txt += " with topping";
            if (icing != "" && icing != "None") txt += $" with {icing}";
            txt += $". Cost: {price}$.";
            return txt;
        }
    }
}
