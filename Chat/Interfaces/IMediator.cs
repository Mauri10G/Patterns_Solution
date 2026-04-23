namespace Chat.Interfaces;

public interface IMediator
{
    // Metodo para enviar un mensaje a un usuario
    void Notify(IUser sender, string message);
}
