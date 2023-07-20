using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Services
{
    public class MenuServiceForTeacher
    {
        private static TeacherService teacherService = new TeacherService();
        public static void MenuShowTeachers()
        {
            var teachers = teacherService.GetTeachers();
            if (teachers.Count == 0)
            {
                Console.WriteLine("No teachers yet!");
                return;
            }
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"ID:{teacher.ID} | Name:{teacher.Name}| Surname:{teacher.Surname}| Grade:{teacher.Salary} | BirthDay:{teacher.BirthDay}");
            }
        }
        public static void MenuAddTeachers()
        {
            try
            {

                Console.WriteLine("Please enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Please enter salary:");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter birthday:(MM/dd/yyyy)");
                DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                teacherService.AddTeachers(name, surname, salary, birthday);
                Console.WriteLine("Added teacher succesfuly");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error!{ex.Message}");
            }
        }
        public static void MenuUpdateTeacher()
        {
            try
            {

                Console.WriteLine("Please enter ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Please enter salary:");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter birthday:(MM/dd/yyyy)");
                DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                teacherService.UpdateTeacher(id, name, surname, salary, birthday);

                Console.WriteLine("Updated teacher succesfuly");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error!{ex.Message}");
            }
        }
        public static void MenuRemoveTeacher()
        {
            try
            {
                Console.WriteLine("Please enter teacher's ID");
                int id = Convert.ToInt32(Console.ReadLine());
                teacherService.RemoveTeacher(id);
                Console.WriteLine("Deleted teacher succesfuly");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error!{ex.Message}");
            }
        }
        public static void MenuFindTeachersByName()
        {
            try
            {
                Console.WriteLine("Enter name for search:");
                string name = Console.ReadLine();
                var foundsteachers = teacherService.FindTeachersByName(name);
                if (foundsteachers.Count == 0)
                {
                    Console.WriteLine("No teachers found.");
                }
                foreach (var teacher in foundsteachers)
                {
                    Console.WriteLine(($"ID:{teacher.ID} | Name:{teacher.Name}| Surname:{teacher.Surname}| Grade:{teacher.Salary} | BirthDay:{teacher.BirthDay}"));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Not found {ex.Message} ");
            }
        }
        public static void MenuSearchTeachersByBday()
        {
            try
            {

                Console.WriteLine("Enter minimum date(MM/dd/yyyy)");
                DateTime minbDay = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter max date(MM/dd/yyyy)");
                DateTime maxbDay = Convert.ToDateTime(Console.ReadLine());
                var foundTeachers = teacherService.SearchTeachersByBday(minbDay, maxbDay);
                if (foundTeachers.Count == 0)
                {
                    Console.WriteLine("No students found!");
                    return;
                }
                foreach (var teacher in foundTeachers)
                {
                    Console.WriteLine(($"ID:{teacher.ID} | Name:{teacher.Name}| Surname:{teacher.Surname}| Grade:{teacher.Salary} | BirthDay:{teacher.BirthDay}"));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error! {ex.Message}");
            }
        }
       
    }
}

