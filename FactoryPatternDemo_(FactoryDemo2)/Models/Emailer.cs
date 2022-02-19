using FactoryPatternDemo__FactoryDemo2_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo__FactoryDemo2_.Models
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IStudent student, string message)
        {
            Console.WriteLine($"\nSending an email to: {student.SupervisorEmailAddress} \n{message} ");
        }
    }
}
