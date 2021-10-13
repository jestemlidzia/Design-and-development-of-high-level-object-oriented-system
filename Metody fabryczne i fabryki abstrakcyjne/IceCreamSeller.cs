namespace LAB05_IceCreamFactory
{
    class IceCreamSeller
    {
        IceCreamFactory factory;
        public IceCreamSeller(IceCreamFactory factory_)
        {
            factory = factory_;

        }
        public Icecream ProposeIceCreamTaste()
        {
            Icecream ice = factory.DailySpecial();
            return ice;
        }
    }
}
