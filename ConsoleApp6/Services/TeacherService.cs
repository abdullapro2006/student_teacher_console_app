using ConsoleApp6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Services
{
    public class TeacherService
    {
        private List<Teacher> teachers;

        public TeacherService()
        {
            teachers = new();
        }

     

        public void AddTeachers(string name, string surname, int salary, DateTime birthday)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            if (string.IsNullOrWhiteSpace(surname)) throw new Exception("Surname can't be empty!");
            if (salary < 0) throw new Exception("Salary can't be negative!");
            var teacher = new Teacher(name, surname, salary, birthday);
            teachers.Add(teacher);
        }
        public List<Teacher> GetTeachers() 
        {
            return teachers;
        }

        public void RemoveTeacher(int id)
        {
            if (id < 0) throw new Exception("ID can't be negative!");
            var existingstudent = teachers.FirstOrDefault(x => x.ID == id);
            if (existingstudent == null) throw new Exception("Not found");
            teachers = teachers.Where(x => x.ID != id).ToList();
        }
        public List<Teacher> FindTeachersByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            var foundteachers = teachers.Where(x => x.Name.ToLower().Trim() == name.ToLower().Trim()).ToList();
            return foundteachers;
        }
        public void UpdateTeacher(int id, string name, string surname, int salary, DateTime birthday)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            if (string.IsNullOrWhiteSpace(surname)) throw new Exception("Surname can't be empty!");
            if (salary < 0) throw new Exception("Salary can't be negative!");
            var existingteacher = teachers.FirstOrDefault(x => x.ID == id);
            if (existingteacher == null) throw new Exception("Student not found!");
            existingteacher.Name = name;
            existingteacher.Surname = surname;
            existingteacher.Salary = salary;
            existingteacher.BirthDay = birthday;
        }
        public List<Teacher> SearchTeachersByBday(DateTime minBday, DateTime maxBday)
        {
            if (minBday > maxBday) throw new Exception("MinBday can't be more than MaxBday");
            return teachers.Where(x => x.BirthDay >= minBday && x.BirthDay <= maxBday).ToList();

        }
    }
}
