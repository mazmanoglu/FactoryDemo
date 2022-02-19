using FactoryPatternDemo__FactoryDemo2_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo__FactoryDemo2_.Models
{
    public class ToDo : IToDo // IToDo= bunu ilk basta implement ettigimizde hata verir cunku burada kullandigimiz diger siniflara
                              // kendi interface'lerini implement ettik. o yuzden burada da onlari cagirmamiz gerekir.
                              // IToDo eklentisinden onceki degisiklikleri comment'e aliyoruz, boylece degisiklikleri de 
                              // gorme sansimiz olacak.
                              // private readonly prop'lari ve ctor'u da IToDo'dan sonra ekliyoruz.
                              // Detayli bilgi icin Kenan Hocanin Factory Pattern Revisited (28 January) videosuna bak.

    {
        private readonly IMessageSender _messageSender;
        private readonly ILogger _logger;

        public string ToDoName { get; set; }
        public IStudent Student { get; set; } 
        // public Student Student { get; set; }
        public double Hours { get; set; }
        public bool IsDone { get; set; }


        public ToDo(IMessageSender messageSender, ILogger logger)
        {
            _messageSender = messageSender;
            _logger = logger;
        }

        public void PerformedWork(double hours)
        {
            //Logger logger = new Logger();
            _logger.Log($"Log activity: Worked on '{ToDoName}'. Worked hours {hours}");
            Hours += hours;
        }
        public void FinishedToDo()
        {
            IsDone = true;
            //Logger logger = new Logger();
            _logger.Log($"Log activity: '{ToDoName}' is finished. Total worked hours {Hours}");

            //Emailer emailer = new Emailer();
            _messageSender.SendMessage(Student, $"Message: The work '{ToDoName}' is finished. Total worked hours: {Hours}");
        }
    }
}
