using FactoryPatternDemo__FactoryDemo2_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo__FactoryDemo2_.Models
{
    public class Logger : ILogger
    {
        public void Log (string message)
        {
            Console.WriteLine($"Message: {message}");
        }
    }
}
