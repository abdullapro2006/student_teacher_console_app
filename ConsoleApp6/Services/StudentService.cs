using ConsoleApp6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Services
{
    public class StudentService
    {
        private List<Student> students;

        public StudentService()
        {
            students = new();
        }
        public void AddStudent(string name,string surname,double grade,DateTime birthday)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            if (string.IsNullOrWhiteSpace(surname)) throw new Exception("Surname can't be empty!");
            if (grade < 0) throw new Exception("Grade can't be negative!");
            var student = new Student(name, surname, grade,birthday);
            students.Add(student);
        }
        public  List<Student> GetStudents()
        {
            return students;
        }
        public void RemoveStudent(int id)
        {
            if (id < 0) throw new Exception("ID can't be negative!");
            var existingstudent = students.FirstOrDefault(x => x.ID == id);
            if (existingstudent == null) throw new Exception("Not found");
            students = students.Where(x=> x.ID != id).ToList();
        }
        public List<Student> FindStudentsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            var foundstudent = students.Where(x=> x.Name.ToLower().Trim() == name.ToLower().Trim()).ToList();
            return foundstudent;
        }
        public void UpdateStudent(int id,string name,string surname,double grade,DateTime birthday)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            if (string.IsNullOrWhiteSpace(surname)) throw new Exception("Surname can't be empty!");
            if (grade < 0) throw new Exception("Grade can't be negative!");
            var existingstudent = students.FirstOrDefault(x=>x.ID == id);
            if (existingstudent == null) throw new Exception("Student not found!");
            existingstudent.Name = name;
            existingstudent.Surname = surname;
            existingstudent.Grade = grade;
            existingstudent.BirthDay = birthday;
        }
        public List<Student> SearchStudentsByBday(DateTime minBday,DateTime maxBday)
        {
            if (minBday > maxBday) throw new Exception("MinBday can't be more than MaxBday");
            return students.Where(x=> x.BirthDay >= minBday && x.BirthDay <= maxBday).ToList();

        }
    }
}
