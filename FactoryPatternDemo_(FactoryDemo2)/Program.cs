using FactoryPatternDemo__FactoryDemo2_.Interfaces;
using FactoryPatternDemo__FactoryDemo2_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo__FactoryDemo2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student()
            IStudent student = Builder.GetStudent();

            student.FirstName = "Nese";
            student.LastName = "Dikmen";
            student.SupervisorEmailAddress = "fatihozer246@hotmail.com";
            student.SupervisorPhone = "0471 62 57 26";

            //ToDo studentTodo = new ToDo() {.............................}
            IToDo studentTodo = Builder.GetToDo();

            studentTodo.ToDoName = "Installed SQL Server DB";
            studentTodo.Student = student;

            studentTodo.PerformedWork(4);
            studentTodo.PerformedWork(5);

            studentTodo.FinishedToDo();
        }
    }
}
