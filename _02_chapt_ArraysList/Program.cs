

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

                months[month - 1] = name;  // zero based index so subtract 1
            }

            // print out the months
            foreach (string month in months)
            {
                Console.WriteLine($"{month}");
            }

            Console.WriteLine();  // space in output

            // multi-dimentional arrays
            int[,] myNumbers = new int[,] 
                {
                    { 9, 10 },
                    {-3, 6 },
                    { 4, -10}
            
                };
            Console.WriteLine($"1st Line: {myNumbers[0, 0]}, {myNumbers[0, 1]}");
            Console.WriteLine($"2nd Line: {myNumbers[1, 0]}, {myNumbers[1, 1]}");
            Console.WriteLine($"3rd Line: {myNumbers[2, 0]}, {myNumbers[2, 1]}");
            
            Console.WriteLine();  // space in output
            
            int changeFLine = myNumbers[0, 0];
            Console.WriteLine($"assign changeFLine <-- myNumbers[0, 0] = {changeFLine}");
            myNumbers[0, 0] = changeFLine +2;

            Console.WriteLine($"1st Line changed: {myNumbers[0, 0]}, {myNumbers[0, 1]}");
        }
    }
}