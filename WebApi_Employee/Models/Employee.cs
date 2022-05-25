using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Employee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Salary { get; set; }

    }
}
