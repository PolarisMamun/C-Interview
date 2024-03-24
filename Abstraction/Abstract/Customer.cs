using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Abstract
{
    public abstract class Customer
    {
        public int i1;
        public void Print1()
        {
            Console.WriteLine("Print1 in Customer");
        }
        public abstract void Print2();
    }
}
