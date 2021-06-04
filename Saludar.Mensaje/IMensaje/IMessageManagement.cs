namespace Saludar.Mensajes.IMensaje
{
    using Saludar.Mensajes.Enum;

    public interface IMessageManagement
    {
        string GetMessage(MessageType messageTypeEnum);

        string GetMessage(MessageType messageTypeEnum, params object[] value);
    }
}