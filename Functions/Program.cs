using System;
using static Functions.Function;
namespace Functions
{
    public class Program
    {
        //In C#, a function is a block of code that performs a specific task. Functions help to organize code, promote reusability, and make code more readable and maintainable.

       // A function consists of a name, a set of parameters, and a body.The body of the function contains the code that performs the desired action.
        //In C#, you can define functions in different files and call them in the main method by using namespaces and using directives.
        static void Main(string[] args)
        {
            DisplayMessage();

            Console.Write("Enter a Word: ");
            string input = Console.ReadLine();

            string upperMessage = ConvertToUpperCase(input);
            Console.WriteLine(upperMessage);

            Console.Write("Enter 1st Number: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Number: ");
            int y = Int32.Parse(Console.ReadLine());

            int sum = Add(x, y);

            Console.WriteLine(sum);


            Console.ReadLine();
        }
    }
}
