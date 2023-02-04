using FactoryMethodDesignPattern.Factory;



var creditCard = new MoneyBackFactory().Create();

if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}