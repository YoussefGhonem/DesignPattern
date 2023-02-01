using MediatorDesignPattern;

IFacebookGroupMediator mediator = new ConcreteFacebookGroupMediator();

User youssef = new ConcreteUser(mediator, "youssef");
User farghaly = new ConcreteUser(mediator, "farghaly");
User gamal = new ConcreteUser(mediator, "gamal");
User hussien = new ConcreteUser(mediator, "hussien");
User saleh = new ConcreteUser(mediator, "saleh");
User abdo = new ConcreteUser(mediator, "abdo");
User ahmed = new ConcreteUser(mediator, "ahmed");

mediator.RegisterUser(youssef);
mediator.RegisterUser(farghaly);
mediator.RegisterUser(gamal);
mediator.RegisterUser(hussien);
mediator.RegisterUser(saleh);
mediator.RegisterUser(abdo);
mediator.RegisterUser(ahmed);


youssef.Send("Desgin Pattern Group - he Mediator Design Pattern falls under the category of Behavioural Design Pattern.");
Console.WriteLine();

farghaly.Send("Desgin Pattern Group - What is Design Patterns? Please explain ");
Console.Read();