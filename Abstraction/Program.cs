using System;

namespace Abstraction
{
    public class Program
    {
        /*
         * An abstract class is a class that cannot be instantiated, but it can be inherited by other classes. An abstract class can have both abstract and concrete methods. Abstract methods are those that do not have an implementation, while concrete methods have an implementation. Abstract methods must be implemented by the derived classes.
         */

        /*
         * An interface is a contract that defines a set of methods and properties that a class must implement. An interface cannot contain any implementation details. It only defines the signatures of the methods and properties.
         */
        static void Main(string[] args)
        {
            MainClass mainClass = new MainClass();
            mainClass.i1 = 1;
            Console.WriteLine("Hello World!");
        }
    }
}
