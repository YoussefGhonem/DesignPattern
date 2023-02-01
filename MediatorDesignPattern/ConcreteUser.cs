
namespace MediatorDesignPattern
{
    public class ConcreteUser : User
    {
        protected IFacebookGroupMediator _mediator;
        protected string _name;
        public ConcreteUser(IFacebookGroupMediator mediator, string name ):base(mediator, name)
        {
            _mediator= mediator;
            _name= name;
        }
        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message =" + message + "\n");
            mediator.SendMessage(message,this);
        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }
    }
}
