using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Student
    {
        int RollNo;
        string Name;
        string Department;
        float TotalMarks;

        public void AcceptStudent()
        {
            Console.WriteLine("Enter student details");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Department = Console.ReadLine();
            TotalMarks = Convert.ToSingle(Console.ReadLine());

        }

        public static void DisplayStudent()
        {
            Console.WriteLine($"Roll No:{RollNo},Name:{Name},Department:{Department}");

        }
    }public static string Wishes()
    {
        return "Hello Everyone";
    }
    class Program
    {
        static void Main(string[] args)

        {
            Student student = new Student();
            student.AcceptStudent();
            student.DisplayStudent();

            student.Wishes();
            Student stud = new Student();
            stud.AcceptStudent();
            stud.DisplayStudent();
            Student.Wishes();



        }
    }
}
