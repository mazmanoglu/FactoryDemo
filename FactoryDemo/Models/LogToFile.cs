using FactoryDemo.Interfaces;
using System;
using System.Configuration;
using System.IO;

namespace FactoryDemo.Models
{
    public class LogToFile : ILogger
    {
        public void Log(string message)
        {
            string path = ConfigurationManager.AppSettings["file"];

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(DateTime.Now + " " + message);
            }
        }
    }
}
