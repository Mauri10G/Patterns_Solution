
using Chat.Interfaces;

namespace Chat.ConcrateClass;

public class User : IUser
{
    private readonly string _name;
    private IMediator _mediator;

    public User(string name)
    {
        _name = name;
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
    public void Send(string message)
    {
        throw new NotImplementedException();
    }
    public void Receive(string message)
    {
        throw new NotImplementedException();
    }

}
