using System;

namespace ErrorHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = 6, b =98;
            double result;

            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Attempted divide by zero");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
    }
}
