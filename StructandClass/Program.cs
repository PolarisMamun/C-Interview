using System;

namespace StructandClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Working with the struct
            PointStruct structPoint = new PointStruct(10, 20);
            Console.WriteLine("Initial Struct Point:");
            structPoint.Display();

            // Copying structPoint to another struct
            PointStruct anotherStructPoint = structPoint;
            anotherStructPoint.X = 50; // Modifying copy
            Console.WriteLine("\nAfter modifying the copy:");
            Console.WriteLine("Original Struct Point:");
            structPoint.Display();
            Console.WriteLine("Copied Struct Point:");
            anotherStructPoint.Display();


            // Working with the class
            PointClass classPoint = new PointClass(10, 20);
            Console.WriteLine("\nInitial Class Point:");
            classPoint.Display();

            // Copying classPoint to another class
            PointClass anotherClassPoint = classPoint;
            anotherClassPoint.X = 50; // Modifying reference
            Console.WriteLine("\nAfter modifying the reference:");
            Console.WriteLine("Original Class Point:");
            classPoint.Display();
            Console.WriteLine("Copied Class Point:");
            anotherClassPoint.Display();
        }
    }
}
