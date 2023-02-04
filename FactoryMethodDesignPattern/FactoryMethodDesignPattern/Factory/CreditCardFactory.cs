namespace FactoryMethodDesignPattern.Factory
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard Create();

        public  ICreditCard CreateCreditCard()
        {
            return Create();
        }
    }
}
