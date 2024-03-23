using System;
using System.Collections.Generic;

namespace LINQLambdaEpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
                List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

                evenNumbers.ForEach( x => Console.WriteLine(x));
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
        }
    }
}
