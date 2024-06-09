using System;
using System.Xml.Serialization;

namespace MoreGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctEmail = "Admin123!";
            string correctPassword = "Admin123";

            int attempts = 3;
            bool isAuthenticated = false;

            while (attempts > 0)
            {
                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (email == correctEmail && password == correctPassword)
                {
                    isAuthenticated = true; break;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again."); attempts--;
                    Console.Clear();
                }
            }

            if (!isAuthenticated)
            {
                Console.WriteLine("Authentication failed. Exiting the program."); return;
            }

            string choice;
            do
            {
                Console.Clear();
                Console.Write("Enter the number of grades: ");
                int numberOfGrades = Convert.ToInt16(Console.ReadLine());

                double[] grades = new double[numberOfGrades];

                Console.Clear();
                for (int i = 0; i < numberOfGrades; i++)
                {
                    Console.Write("Enter grade " + (i + 1) + ": ");
                    double grade = Convert.ToDouble(Console.ReadLine());

                    if (grade < 1 || grade > 100)
                    {
                        Console.WriteLine("Invalid input. Grade must be between 1 and 100."); i--; // Decrement i to repeat the current iteration
                        continue;
                    }

                    grades[i] = grade;
                }

                double sum = 0;
                for (int i = 0; i < numberOfGrades; i++)
                {
                    sum += grades[i];
                }

                double average = sum / numberOfGrades;

                string equivalentGrade;

                if (average < 50)
                {
                    equivalentGrade = "FAILED";
                }
                else if (average > 50 && average <= 70)
                {
                    equivalentGrade = "FAIR";
                }
                else if (average > 70 && average <= 80)
                {
                    equivalentGrade = "GOOD";
                }
                else if (average > 80 && average <= 90)
                {
                    equivalentGrade = "VERY GOOD";
                }
                else
                {
                    equivalentGrade = "EXCELLENT";
                }
                Console.WriteLine("The average grade is: " + average);
                Console.WriteLine("Equivalent grade: " + equivalentGrade);
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Do you want to compute another set of Grades? (Y/N)");
                choice = Console.ReadLine();
            }
            while (choice == "Yes" || choice == "yes" || choice == "Y" || choice == "y");
            Console.Clear();
            Console.Write("Have a good day!");
            
        }
    }
}
    

