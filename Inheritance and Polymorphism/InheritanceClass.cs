using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    /* Inheritance : - 
     * When a class inherits from another class, it is called inheritance.
     * In this example, Dog and Cat inherit from Animal. They inherit the Name property 
     * and can use the MakeSound method. However, 
     * they also override MakeSound to provide their specific sounds.
     */
    public class Animal
    {
        public string Name { get; set; }
        public virtual void MakeSound() 
        { 
            Console.WriteLine("Generic animal sound"); 
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound() 
        { 
            Console.WriteLine("Woof!"); 
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound() 
        { 
            Console.WriteLine("Meow!"); 
        }
    }   
}
