using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Interview.AbstractClass
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class AbstractTest : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("It's cat sound");
        }
    }
}
