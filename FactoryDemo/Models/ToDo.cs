using FactoryDemo.Interfaces;

namespace FactoryDemo.Models
{
    public class ToDo : IToDo
    {
        private readonly IMessageSender _messageSender;
        private readonly ILogger _logger;

        public ToDo(IMessageSender messageSender, ILogger logger)
        {
            _messageSender = messageSender;
            _logger = logger;
        }

        public string ToDoName { get; set; }
        public IStudent Student { get; set; }
        public double Hours { get; set; }
        public bool IsDone { get; set; }

        public void PerformedWork(double hours)
        {
            //Logger logger = new Logger();
            _logger.Log($"Log activity : Work Done on {ToDoName}, worked hours {hours}");
            Hours += hours;
        }
        public void FinishedToDo()
        {
            IsDone = true;
            //Logger logger = new Logger();
            _logger.Log($"Log activity closed for {ToDoName}, total worked hours {Hours}");

            //Emailer emailer = new Emailer();
            _messageSender.SendMessage(Student, $"Subject: The Work {ToDoName} is finished, with total worked hours {Hours}");
        }
    }
}

// bu program calismakla birlikte kotu bir program cunku her metodda ayni sinifi tekrar tekrar olusturduk.
// kisa programlarda bir sorun yasanmamakla birlikte buyuk programlarda bu ciddi problemler olusturur.
// her olusturdugun gereksiz "new", programi agirlastirir.
// solid mantiginin "(D)ependency" kismini incele. (dependency inversion of control)
// dependency inversion of control ile dependency injection'i karistirma. ikincisini daha sonra gorecegiz.
// concrete class, icerisinde abstract icermeyen, herseyin deklare edildigi siniftir.
// ama interface'ler concerete class degildir, bir abstracttir.
