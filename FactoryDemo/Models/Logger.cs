using FactoryDemo.Interfaces;
using System;

namespace FactoryDemo.Models
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
