using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Default constructor (parameterless)
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        // Constructor with parameters
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
