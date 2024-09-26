using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    public class MathOperation
    {
        /*
         * Compile-time Polymorphism (Method Overloading): 
         * It allows a class to have multiple methods with the same name but different parameters.
         */
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
