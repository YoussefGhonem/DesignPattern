
namespace MediatorDesignPattern
{
    public abstract class User
    {
        protected IFacebookGroupMediator mediator;
        protected string name;

        protected User(IFacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string msg);
        public abstract void Receive(string msg);
    }
}
