namespace _02_b_Methods
{

    class BigApp
    {
        public void MyPrint()
        {
            Console.WriteLine("Hello ");
        }

        // overloading
        public void MyPrint(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public void MyPrint(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }


        public void MyPrint(int num)
        {
            Console.WriteLine("Your Big App number is " + num);
        }

        // params keyword - allows the passing of a variable number of arguments
        public void MyPrint(params string[] str)
        {
            foreach (var s in str)
            {
                Console.Write(s + " ");
            }
            Console.Write("\n");
        }

        // option parameters
        public void MyPrint(string name, int age = 0)
        {
            Console.WriteLine("Hello " + name + " " + age);
        }

        // with return type
        public int MyPrint(int num1, int num2)
        {
            return num1 + num2;
        }

        // ref keyword
        public void Set(ref int i)
        {
            i = 10;
        }

        // out keyword
        public void Set(out string str)
        {
            str = "Biggy Bigs";
        }

    }
    
    class CountUp
    {
        // recursive method
        public void CountingUp()
        {
            int c = 20;
            Recursive(c);
            Console.WriteLine("\nCompleted!");

            void Recursive(int i)
            {
                if (i > 0)
                {
                    Console.Write(i + " ");
                    System.Threading.Thread.Sleep(250);  // waiting 0.25 sec.
                    Recursive(i - 1);  // recursive call
                }
            }

        } 
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // call methods
            BigApp app = new BigApp();
            app.MyPrint();
            // overloading
            app.MyPrint("Mr.", "BigApp");
            app.MyPrint("Big App");
            app.MyPrint(7);
            // params keyword
            app.MyPrint("Kittens", "Happy", "lemmons");
            // option parameters
            app.MyPrint("Baby");
            app.MyPrint("Sir", 45);
            // named arguments to the parameters
            app.MyPrint(age: 78, name: "Septuagenarian");
            app.MyPrint(name: "Another Septuagenarian", 74);
            // with return type
            Console.WriteLine("Your Big App number is " + app.MyPrint(3, 9));
            // ref keyword
            int y = 5;
            app.Set(ref y);  // pass ref
            Console.WriteLine(y);
            // out keyword
            string phrase = "Smally Bigs";
            app.Set(out phrase);  // pass out
            Console.WriteLine(phrase);

            Console.WriteLine();  // space

            // recursive method - seperate class
            new CountUp().CountingUp();

        }
    }
}