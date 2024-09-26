using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructandClass
{
    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor to initialize the class
        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to display the point's coordinates
        public void Display()
        {
            Console.WriteLine($"Class Point: ({X}, {Y})");
        }
    }
}
