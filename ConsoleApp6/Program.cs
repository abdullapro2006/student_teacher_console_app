// See https://aka.ms/new-console-template for more information

using ConsoleApp6.Helpers;
using ConsoleApp6.Services;
using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int option;

        do
        {
            Console.WriteLine("1. For students");
            Console.WriteLine("2. For teachers");
            Console.WriteLine("0. Go Back");
            Console.WriteLine("-------------");
            Console.WriteLine("Please select an option");
            Console.WriteLine("--------------");

            while(!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Please enter a valid option");
                Console.WriteLine("---------------");
            }

            switch (option)
            {
                case 1:
                    SubMenu.StudentSubMenu();
                    break;
                case 2:
                    SubMenu.TeacherSubMenu();
                    break;
                case 0:
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("No such option!");
                    break;
            }
        } while (option != 0);
    }
}
