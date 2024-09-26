using System;
using System.Collections.Generic;

namespace Inheritance_and_Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());

            foreach (Animal animal in animals)
            {
                animal.MakeSound(); // Calls the overridden MakeSound in each derived class
            }
            /*
             * In this example, we can add objects of both Dog and Cat to a list of Animal.
             * Then, we can iterate through the list and call MakeSound on each object 
             * using the polymorphic behavior.
             */
        }
    }
}
