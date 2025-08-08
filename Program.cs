using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroupCategories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user's age
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            // Validate and classify
            if (int.TryParse(input, out int age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Error: Age cannot be negative.");
                }
                else
                {
                    string category = ClassifyAge(age);
                    Console.WriteLine($"Age Category: {category}");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid integer for age.");
            }
        }
        static string ClassifyAge(int age)
        {
            if (age <= 12) return "Child";
            if (age <= 19) return "Teen";
            if (age <= 59) return "Adult";
            return "Senior";
        }
    }
}
