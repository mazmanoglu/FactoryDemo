using FactoryDemo.Interfaces;
using System;

namespace FactoryDemo.Models
{
    public class SMS : IMessageSender
    {
        public void SendMessage(IStudent student, string message)
        {
            Console.WriteLine($"Sending SMS to {student.SupervisorPhone}");
            Console.WriteLine("This line is added just for fun.");
        }
    }
}
