

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
            myNumbers[0, 0] = changeFLine + 2;

            Console.WriteLine($"1st Line changed: {myNumbers[0, 0]}, {myNumbers[0, 1]}");

            Console.WriteLine();  // space in output

            // multiplication table via multi-dimentional array
            int[,] multiplicationTable = new int[10, 10];

            // calculate the multiplication table
            for (int x = 0; x < multiplicationTable.GetLength(0); x++)
            {
                for (int y = 0; y < multiplicationTable.GetLength(1); y++)
                {
                    multiplicationTable[x, y] = (x + 1) * (y + 1);
                }
            }

            // print out the multiplication table
            for (int x = 0; x < multiplicationTable.GetLength(0); x++)
            {
                for (int y = 0; y < multiplicationTable.GetLength(1); y++)
                {
                    Console.Write("{0, 4}", multiplicationTable[x, y]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();  // space in output

            // simple jagged array - array of arrays with irregualr dimentions
            string[][] jaggedArrayA =  // assigned during allocation  -- this has a visual aspect that may make more sense
                {
                    new string[] { "alpha a" },
                    new string[] { "beta a", "beta b"},
                    new string[] { "gamma a", "gamma b", "gamma c"},
                    new string[] { "delta a", "delta b"}
            };

            Console.WriteLine(jaggedArrayA[0][0]);  // alpha a
            Console.WriteLine(jaggedArrayA[1][1]);  // beta b
            Console.WriteLine(jaggedArrayA[2][2]);  // gamma c
            Console.WriteLine(jaggedArrayA[3][0]);  // delta a

            Console.WriteLine();  // space in output

            Console.WriteLine("=== as a table ===");
            // output a table-like display
            var tabled = string.Format("{0, 8}\n", jaggedArrayA[0][0]) +
                string.Format("{0, 7}", jaggedArrayA[1][0]) +  // word length adjustment
                string.Format("{0, 7}\n", jaggedArrayA[1][1]) +
                string.Format("{0, 8}", jaggedArrayA[2][0]) +
                string.Format("{0, 8}", jaggedArrayA[2][1]) +
                string.Format("{0, 8}\n", jaggedArrayA[2][2]) +
                string.Format("{0, 8}", jaggedArrayA[3][0]) +
                string.Format("{0, 8}", jaggedArrayA[3][1]);

            Console.WriteLine(tabled);

            Console.WriteLine();  // space in output

            // allocated one at a time
            string[][] jaggedArrayB = new string[3][];
            jaggedArrayB[0] = new string[1];
            jaggedArrayB[0][0] = "First line a";

            jaggedArrayB[1] = new string[3];
            jaggedArrayB[1][0] = "Second line a";
            jaggedArrayB[1][1] = "Second line b";
            jaggedArrayB[1][2] = "Second line c";

            Console.WriteLine(jaggedArrayB[0][0]);  // alpha a
            Console.WriteLine(jaggedArrayB[1][0]);  // beta a
            Console.WriteLine(jaggedArrayB[1][1]);  // beta b
            Console.WriteLine(jaggedArrayB[1][2]);  // beta c

             

        }
    }
}