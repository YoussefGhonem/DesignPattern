using System.Reflection.Metadata;

namespace MediatorDesignPattern;

    public  interface IFacebookGroupMediator
    {
        public void RegisterUser(User user);
        public void SendMessage(string msg, User user);
    }

