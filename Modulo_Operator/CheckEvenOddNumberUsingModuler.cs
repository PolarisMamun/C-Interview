using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Operator
{
    public class CheckEvenOddNumberUsingModuler : AbstractClass
    {
        //need to learn some more thing
        public override int CheckOddEvenNumber(int number)
        {
            int evenCount = 0;
            int oddCount = 0;
            for(int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    evenCount++;
                }

                else
                {
                    oddCount++;
                }
            }                        
            Console.WriteLine("\n\nTotal Even number : {0} ", evenCount);
            Console.WriteLine("\n\nTotal Odd Number : {0} ", oddCount);
            return number;
        }
    }
}
