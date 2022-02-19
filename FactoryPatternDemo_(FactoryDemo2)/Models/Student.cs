using FactoryPatternDemo__FactoryDemo2_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo__FactoryDemo2_.Models
{
    public class Student : IStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SupervisorEmailAddress { get; set; }
        public string SupervisorPhone { get; set; }

    }
}
