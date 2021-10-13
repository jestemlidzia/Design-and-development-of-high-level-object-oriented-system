namespace LAB05_IceCreamFactory
{
    class IceCreamFactory
    {
        Days productionMode;

        public Days ProductionMode
        {
            get { return productionMode; }
            set
            {
                productionMode = value;
            }
        }

        public IceCreamFactory(Days productionMode_)
        {
            productionMode = productionMode_;
        }
        public Icecream DailySpecial()
        {
            Icecream ice = new Sorbet(3, "Mango");

            switch (productionMode)
            {
                case Days.Monday:
                    ice = new FruitIce(4, "Raspberry", false, "white chockolate");
                    break;
                case Days.Tuesday:
                    ice = new CreamIce(3, "Vanilla", true, "milk chockolate", true);
                    break;
                case Days.Wednesday:
                    ice = new FruitIce(2, "Lemon", false, "frosting");
                    break;
                case Days.Thursday:
                    ice = new Sorbet(3, "Mango");
                    break;
                case Days.Friday:
                    ice = new FruitIce(4, "Strawberry", true, "dark chockolate");
                    break;
                case Days.Saturday:
                    ice = new ItalianIce(5, "Stawberry-chockolate", true, true);
                    break;
                case Days.Sunday:
                    ice = new CreamIce(6, "Banana", true, "strawberry", true);
                    break;
            }

            return ice;

        }

        public void setProductionMode(Days type)
        {
            productionMode = type;
        }
    }
}
