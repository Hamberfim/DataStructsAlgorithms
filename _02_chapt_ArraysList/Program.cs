

using System.Globalization;

namespace _02_chapt_ArraysList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // single dimensional array.
            // An array to store the names of the months via DateTime rather than hard coded.
            string[] months = new string[12];

            for (int month = 1; month <= 12; month++)  // loop thru months 1 - 12
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);

                // cultural info set to english
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-us"));

                months[month - 1] = name;
            }

            // print out the months
            foreach (string month in months)
            {
                Console.WriteLine($"{month}");
            }

            Console.WriteLine();  // space in output
        }
    }
}