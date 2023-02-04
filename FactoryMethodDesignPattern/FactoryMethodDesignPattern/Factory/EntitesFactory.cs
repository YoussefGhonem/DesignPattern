using FactoryMethodDesignPattern.Entites;

namespace FactoryMethodDesignPattern.Factory
{
    public class MoneyBackFactory : CreditCardFactory
    {
        public override ICreditCard Create()
        {
            ICreditCard card = new MoneyBack();
            return card;
        }
    }
    public class PlatinumFactory : CreditCardFactory
    {
        public override ICreditCard Create()
        {
            ICreditCard card = new Platinum();
            return card;
        }
    }
    public class TitaniumFactory : CreditCardFactory
    {
        public override ICreditCard Create()
        {
            ICreditCard card = new Titanium();
            return card;
        }
    }
}
