using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend01B
{
    //a class for a person with name, salary, job, location (Budapest, Szeged, Miskolc)
    public class Worker
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Job { get; set; }
        public string Location { get; set; }

        public Worker()
        {
            
        }

        public Worker(string name, int salary, string job, string location)
        {
            Name = name;
            Salary = salary;
            Job = job;
            Location = location;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}, Job: {Job}, Location: {Location}";
        }
    }
}
