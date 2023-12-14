// Classe ConcreteMediator
public class ChatRoom : IChatRoom
{
    private List<User> _users = new List<User>();

    public void Register(User user)
    {
        _users.Add(user);
    }

    public void Send(string message, User sender)
    {
        foreach (User user in _users)
        {
            if (user != sender)
            {
                user.Receive(message);
            }
        }
    }
}
