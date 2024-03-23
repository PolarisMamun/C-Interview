using System;

namespace ControlStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            //if statement: The if statement in C# is used to execute a block of code if a specified condition is met
            Console.Write("Enter number : ");

            int x = Int32.Parse(Console.ReadLine());

            if(x > 5)
            {
                Console.WriteLine("X is greater than 5");
            }
            //if-else statement: The if-else statement in C# is used to execute one block of code if a specified condition is met and another block of code if it is not.
            else
            {
                Console.WriteLine("X is less than or equal to 5");
            }

            //while loop: The while loop in C# is used to repeatedly execute a block of code as long as a specified condition is true.

            Console.WriteLine("Learn While Loop");
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            //for loop: The for loop in C# is used to repeatedly execute a block of code a specific number of times
            Console.WriteLine("Learn For Loop");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            //foreach loop: The foreach loop in C# is used to iterate through the elements of a collection, such as an array or a list

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("For Each");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            //switch statement: The switch statement in C# is used to execute a block of code based on the value of a variable.
            Console.Write("Enter number 2 :");
            int y = Int32.Parse(Console.ReadLine());
            switch (y)
            {
                case 1:
                    Console.WriteLine("Y is 1");
                    break;
                    case 2:
                    Console.WriteLine("Y is 2");
                    break;
                    case 3:
                    Console.WriteLine("Y is 3");
                    break;
                default:
                    Console.WriteLine("Y is neither 1 nor 2 or 3");
                    break;
            }


            Console.Read();
        }
    }
}
