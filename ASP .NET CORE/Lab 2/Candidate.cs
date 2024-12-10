using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Candidate
    {
        public int ID;
        public string Name;
        public int Age;
        public double Height;
        public double Weight;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Candidate Details:");
            Console.Write("ID: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height (m): ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Weight (kg): ");
            Weight = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("\nCandidate Details:");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} m");
        }

    }
}

