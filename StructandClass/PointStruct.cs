using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructandClass
{
    public struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor to initialize the struct
        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to display the point's coordinates
        public void Display()
        {
            Console.WriteLine($"Struct Point: ({X}, {Y})");
        }
    }
}
