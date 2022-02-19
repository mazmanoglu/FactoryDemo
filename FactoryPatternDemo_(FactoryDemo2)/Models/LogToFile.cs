using FactoryPatternDemo__FactoryDemo2_.Interfaces;
using System;
using System.Configuration;
using System.IO;

namespace FactoryPatternDemo__FactoryDemo2_.Models
{
    public class LogToFile : ILogger
    {
        public void Log(string message)
        {
            //string path = "C:\\textfiles\\LogBuilder.txt";
            string path = ConfigurationManager.AppSettings["path"];
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(DateTime.Now + " " + message);
            }
        }
    }
}
