namespace _02_b_Methods
{

    class BigApp 
    { 
        public void MyPrint()
        {
            Console.WriteLine("Hello ");
        }

        // overloading
        public void MyPrint(string word)
        {
            Console.WriteLine("Hello " + word);
        }

        public void MyPrint(int num)
        {
            Console.WriteLine("Your Big App number is: " + num);
        }


    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // call methods
            BigApp app = new BigApp();
            app.MyPrint();
            app.MyPrint("Big App");
            app.MyPrint(7);

            Console.WriteLine();  // space
        }
    }
}