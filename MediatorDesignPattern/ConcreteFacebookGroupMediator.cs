

namespace MediatorDesignPattern;

public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        List<User> userList = new List<User>();

    public void RegisterUser(User user)
    {
        userList.Add(user);
    }

    public void SendMessage(string msg, User user)
    {
       foreach (var item in userList)
        {
            if (item != user)
            {
                user.Receive(msg);
            }
        }
    }
}
