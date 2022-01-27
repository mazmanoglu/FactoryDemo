
namespace FactoryDemo.Interfaces
{
    public interface IToDo
    {
        double Hours { get; set; }
        bool IsDone { get; set; }
        IStudent Student { get; set; }
        string ToDoName { get; set; }

        void FinishedToDo();
        void PerformedWork(double hours);
    }
}