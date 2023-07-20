using ConsoleApp6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Teacher : BaseEntity
    {
        private static int counter = 0;
        public Teacher(string name,string surname,int salary,DateTime birthday)
        {
            Name = name;
            Salary = salary;
            Surname = surname;
            BirthDay = birthday;
            ID = counter;
            counter++;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
