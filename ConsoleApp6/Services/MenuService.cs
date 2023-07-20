using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Services
{
    public class MenuService
    {
        private static StudentService studentService = new StudentService();
        public static void MenuShowStudents()
        {
            var students = studentService.GetStudents();
            if(students.Count == 0)
            {
                Console.WriteLine("No students yet!");
                return;
            }
            foreach (var student in students)
            {
                Console.WriteLine($"ID:{student.ID} | Name:{student.Name}| Surname:{student.Surname}| Grade:{student.Grade} | BirthDay:{student.BirthDay}");
            }
        }
        public static void MenuAddStudent() 
        {
            try
            {

                Console.WriteLine("Please enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Please enter grade:");
                double grade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter birthday:(MM/dd/yyyy)");
                DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                studentService.AddStudent(name, surname, grade,birthday);
                Console.WriteLine("Added student succesfuly");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error!{ex.Message}");
            }
        }
        public static void MenuUpdateStudent() 
        {
            try
            {

                Console.WriteLine("Please enter ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Please enter grade:");
                double grade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter birthday:(MM/dd/yyyy)");
                DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                studentService.UpdateStudent(id, name, surname,grade,birthday);

                Console.WriteLine("Updated student succesfuly");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error!{ex.Message}");
            }
        }
        public static void MenuRemoveStudent()
        {
            try
            {
                Console.WriteLine("Please enter student's ID");
                int id = Convert.ToInt32(Console.ReadLine());
                studentService.RemoveStudent(id);
                Console.WriteLine("Deleted student succesfuly");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error!{ex.Message}");
            }
        }
        public static void MenuFindStudentsByName() 
        {
            try
            {
                Console.WriteLine("Enter name for search:");
                string name = Console.ReadLine();
                var foundstudents = studentService.FindStudentsByName(name);
                if(foundstudents.Count == 0)
                {
                    Console.WriteLine("No students found.");
                }
                foreach (var student in foundstudents)
                {
                    Console.WriteLine(($"ID:{student.ID} | Name:{student.Name}| Surname:{student.Surname}| Grade:{student.Grade} | BirthDay:{student.BirthDay}"));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Not found {ex.Message} ");
            }
        }
        public static void MenuSearchStudentsByBday()
        {
            try
            {

                Console.WriteLine("Enter minimum date(MM/dd/yyyy)");
                DateTime minbDay = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter max date(MM/dd/yyyy)");
                DateTime maxbDay = Convert.ToDateTime(Console.ReadLine());
                var foundStudents = studentService.SearchStudentsByBday(minbDay, maxbDay);
                if (foundStudents.Count == 0)
                {
                    Console.WriteLine("No students found!");
                    return;
                }
                foreach (var student in foundStudents)
                {
                    Console.WriteLine(($"ID:{student.ID} | Name:{student.Name}| Surname:{student.Surname}| Grade:{student.Grade} | BirthDay:{student.BirthDay}"));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error! {ex.Message}");
            }
        }
        public static void MenuShowTeachers()
        {

        }
    }
}
