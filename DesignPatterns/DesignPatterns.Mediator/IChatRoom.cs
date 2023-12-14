// Interface Mediator
public interface IChatRoom
{
    void Register(User user);
    void Send(string message, User user);
}
