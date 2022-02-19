using FactoryPatternDemo__FactoryDemo2_.Models;

namespace FactoryPatternDemo__FactoryDemo2_.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(IStudent student, string message);
    }
}