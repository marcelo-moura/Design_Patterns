﻿// Classe ConcreteColleague
public class ChatUser : User
{
    public ChatUser(IChatRoom chatRoom) : base(chatRoom) { }

    public override void Send(string message)
    {
        Console.WriteLine("User sends message: " + message);
        _chatRoom.Send(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine("User receives message: " + message);
    }
}
