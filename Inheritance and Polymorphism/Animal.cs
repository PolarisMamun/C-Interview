using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    // Run-time Polymorphism (Method Overriding):
    public class Animaln
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }
    public class Dog1 : Animaln
    {
        override public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
