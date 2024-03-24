using System;

namespace Encapsulation
{
    public class Program
    {
        /*
         * Encapsulation is the process of hiding the internal state and behavior of an object from the outside world.
         * This is achieved by using access modifiers (such as public, private, protected, and internal) to restrict access to the members of a class.
         */
        static void Main(string[] args)
        {
            Account account = new Account();
            account.GetBalance();
            Console.WriteLine("Hello World!");

            Person person = new Person();
            person.FirstName = "Test";
        }
    }
}
