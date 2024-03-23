using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class Function
    {
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello World");
        }
        //In this example, the function DisplayMessage is declared with the void keyword, indicating that it does not return a value. The function contains one statement that prints the message "Hello World!" to the console.

        public static string ConvertToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public static int Add(int x , int y)
        {
            return x + y;
        }
    }
}
