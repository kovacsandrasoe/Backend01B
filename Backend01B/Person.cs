using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend01B
{
    //a class for a person with name, age, job, haircolor, height
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public string HairColor { get; set; }
        public double Height { get; set; }

        public Person()
        {
            
        }

        public Person(string name, int age, string job, string hairColor, double height)
        {
            Name = name;
            Age = age;
            Job = job;
            HairColor = hairColor;
            Height = height;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Job: {Job}, HairColor: {HairColor}, Height: {Height}";
        }
    }
}
