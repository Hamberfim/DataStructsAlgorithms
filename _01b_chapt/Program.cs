﻿namespace _01b_chapt
{
    internal class Program
    {
        // delegates
        delegate double Mean(double a, double b, double c);

        static double Harmonic(double a, double b, double c) 
        {
            return 3 / ((1 / a) + (1 / b) + (1 / c));
        }


        static void Main(string[] args)
        {
            Mean arithmetic = (a, b, c) => (a + b + c) / 3;
            
            Mean geometric = delegate (double a, double b, double c) 
            { 
                return Math.Pow(a * b * c, 1 /3.0); 
            };

            Mean harmonic = Harmonic;

            double arithmeticResult = arithmetic.Invoke(5, 6.5, 7);


            Console.WriteLine();  //space in output
        }
    }
}