using System;

namespace VariablesAndAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            const int max = 50;

            Console.WriteLine("The value of a is = " + a);
            Console.WriteLine("The value of b is = {0} " , b);
            Console.WriteLine("The value of max is = " + max);

            a = 20;
            b = 30;

            Console.WriteLine("The value of a is = " + a);
            Console.WriteLine("The value of b is = {0}", b);
            Console.WriteLine("The value of max is = " + max);
        }
    }
}
