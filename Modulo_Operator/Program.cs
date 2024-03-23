using System;

namespace Modulo_Operator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 3;

            // Example 1: Calculate the remainder of x divided by y
            int result1 = x % y;
            Console.WriteLine("Result 1 : " + result1); // result1 will be 1

            // Example 2: Check if a number is even or odd
            bool isEven = (x % 2) == 0;

            Console.WriteLine("Check isEven : " + isEven); // isEven will be true

            // Example 3: Calculate the number of days in a month

            int daysInMonth = 31;
            int remainingDays = daysInMonth % 7;// remainingDays will be the number of days left after the weekends


            Console.WriteLine("RemainingDays : " + remainingDays);

            // Example 4: Calculate the number of times a value fits into another value

            int value = 10;
            int container = 3;
            int times = value / container + (value % container > 0 ? 1 : 0); // times will be 4 (3 fits into 10 three times, and there is 1 left over)
            Console.WriteLine("Times : " + times);

            // Example 5: Calculate the number of times a value fits into another value, with a remainder of zero

            int value2 = 10;
            int container2 = 5;
            int times2 = value2 / container2; // times2 will be 2 (5 fits into 10 twice, with no remainder)

            Console.WriteLine("Times 2 : "+times2);

            Console.WriteLine("=========Check Odd Even numbers using If=======");
            Console.Write("Enter Number : ");
            int number = Int32.Parse(Console.ReadLine());

            OddEvenNumbersUsingIf oddEven = new OddEvenNumbersUsingIf();
            oddEven.CheckOddEvenNumber(number);

            CheckEvenOddNumberUsingModuler checkEvenOdd = new CheckEvenOddNumberUsingModuler();
            checkEvenOdd.CheckOddEvenNumber(number);


            Console.Read();
        }
    }
}
