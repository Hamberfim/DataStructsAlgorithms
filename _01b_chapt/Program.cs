namespace _01b_chapt
{
    internal class Program
    {
        // delegates  - specifies the required signature of the method for calculating the mean value of a set of 3 numbers
        delegate double Mean(double a, double b, double c);

        static double Harmonic(double a, double b, double c) 
        {
            return 3 / ((1 / a) + (1 / b) + (1 / c));
        }


        static void Main(string[] args)
        {
            // this lambda expression instantiates the delegate
            Mean arithmetic = (a, b, c) => (a + b + c) / 3;

            // instantiate the delegate via anonymous method
            Mean geometric = delegate (double a, double b, double c) 
            { 
                return Math.Pow(a * b * c, 1 /3.0); 
            };

            // instantiate the delegate via named method
            Mean harmonic = Harmonic;

            // each delegate above is then invoked by using the invoke() method
            double arithmeticResult = arithmetic.Invoke(5, 6.5, 7);
            Console.WriteLine(arithmeticResult);
            double geometricResult = geometric.Invoke(5, 6.5, 7);
            Console.WriteLine(geometricResult);
            double harmonicResult = harmonic.Invoke(5, 6.5, 7);
            Console.WriteLine(harmonicResult);

            Console.WriteLine();  //space in output
        }
    }
}