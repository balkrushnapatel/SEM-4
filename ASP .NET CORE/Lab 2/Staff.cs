using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Staff
    {
        public string Name;
        public string Department;
        public string Designation;
        public int Experience;
        public int Salary;

        public void GetStaffDetails()
        {
            Console.WriteLine("Enter Staff Details:");
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Departmnet: ");
            Department = Console.ReadLine();
            Console.Write("Designation: ");
            Designation = Console.ReadLine();
            Console.Write("Experience (in years) : ");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("\nStaff Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Experience: {Experience} years");
            Console.WriteLine($"Salary: {Salary} ");
        }

        public string Design()
        {
            return Designation;
        }
    }
}
