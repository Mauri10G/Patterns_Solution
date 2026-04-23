namespace Chat.Interfaces;

public interface IUser
{
    //Metodo para establecer el mediador a traves del cual se comunicaran los usuarios
    void SetMediator(IMediator mediator);
    //Metodo para enviar un mensaje 
    void Send(string message);
    //Metodo para recibir un mensaje
    void Receive(string message);


}
    