using System.Globalization;

namespace _01c_chapt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate: ");
            // read input from user
            string birthdateString = Console.ReadLine();

            // convert string to date
            if(!DateTime.TryParseExact(birthdateString, "M/d/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out DateTime birthDateTime))
            {
                birthDateTime = DateTime.Now;
            }

            Console.WriteLine($"Your birth day is {birthDateTime}");

            Console.WriteLine();  // space in output
        }
    }
}