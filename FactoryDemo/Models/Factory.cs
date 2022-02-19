using FactoryDemo.Interfaces;

namespace FactoryDemo.Models
{
    public class Factory
    {
        public static IStudent CreateStudent()
        {
            return new Student();
        }

        public static IToDo CreateTodo()
        {
            return new ToDo(CreateMessageSender(), CreateLogger());
        }

        public static ILogger CreateLogger()
        {
            // LogToFile, ciktiyi c'deki text dosyasina yazdirir digeri ekrana.

            //return new Logger();
            return new LogToFile();
        }

        public static IMessageSender CreateMessageSender()
        {
            // kime ne gondermek istiyorsan buradan sec, onu aktive edip digerini commente al.

            return new Emailer();
            //return new SMS();
        }
    }
}
