using FactoryDemo.Interfaces;
using System;

namespace FactoryDemo.Models
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IStudent student, string message)
        {
            Console.WriteLine($"Sending email to: {student.SupervisorEmail}\n{message}");
        }
    }
}
