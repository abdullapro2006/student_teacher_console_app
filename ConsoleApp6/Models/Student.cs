using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    public class Student : BaseEntity
    {
        private static int counter = 0;
        public Student(string name,string surname,double grade,DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Grade = grade;
            BirthDay = birthday;
            ID = counter;
            counter++;
        }
      
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Grade { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
