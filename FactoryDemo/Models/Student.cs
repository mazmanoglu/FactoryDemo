using FactoryDemo.Interfaces;

namespace FactoryDemo.Models
{
    public class Student : IStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SupervisorEmail { get; set; }
        public string SupervisorPhone { get; set; }

    }
}
