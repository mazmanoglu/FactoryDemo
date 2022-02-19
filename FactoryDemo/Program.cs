using FactoryDemo.Interfaces;
using FactoryDemo.Models;

namespace FactoryDemo
{
    internal class Program
    {
        static void Main()
        {
            //IStudent student = new Student(); oncesinde boyleydi ama degistirdik
            // sonra da FirstName yerine student.FirstName yazdik
            IStudent student = Factory.CreateStudent();

            student.FirstName = "Defne";
            student.LastName = "Ozer";
            student.SupervisorEmail = "fatihozer246@gmail.com";
            student.SupervisorPhone = "0492806376";

            IToDo toDo = Factory.CreateTodo();

            toDo.ToDoName = "Console Application";
            toDo.Student = student;

            toDo.PerformedWork(5);
            toDo.PerformedWork(2);
            toDo.FinishedToDo();
        }
    }
}
