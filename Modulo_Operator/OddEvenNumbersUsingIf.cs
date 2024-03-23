using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Operator
{
    public class OddEvenNumbersUsingIf : AbstractClass
    {
        /*public int CheckOddEvenNumber(int number)
        {
            int i = 0;
            int count = 0;
            Console.WriteLine("Even number up to : {0} ",number);
            for(i = 2; i <number; i += 2)
            {
                Console.Write(i + " ");
                count++;
            }
            Console.WriteLine("\n\nTotal Even number : {0} ", count);

            Console.WriteLine("\n\nOdd number up to : {0} ",number);
            for(i = 1; i < number; i += 2)
            {
                Console.Write(i + " ");
                count++;
            }

            Console.WriteLine("\n\nTotal Odd Number : {0} ", count);
            return i;
        }*/
        public override int CheckOddEvenNumber(int number)
        {
            int i = 0;
            int evenCount = 0;
            int oddCount = 0;
            Console.WriteLine("Even number up to : {0} ",number);
            for(i = 2; i <= number; i += 2)
            {
                Console.Write(i + " ");
                evenCount++;
            }
            Console.WriteLine("\n\nTotal Even number : {0} ", evenCount);

            Console.WriteLine("\n\nOdd number up to : {0} ",number);
            for(i = 1; i <= number; i += 2)
            {
                Console.Write(i + " ");
                oddCount++;
            }

            Console.WriteLine("\n\nTotal Odd Number : {0} ", oddCount);
            return i;
        }
    }
}
