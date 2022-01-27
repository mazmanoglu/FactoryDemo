namespace FactoryDemo.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(IStudent student, string message);
    }
}