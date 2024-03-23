using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    //Sealed Restricts the inheritance
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly Lazy<Singleton> instanceLazy = new Lazy<Singleton>(()=>new Singleton());
        private static readonly object obj = new object();
        public static Singleton GetInstance
        {
            /*get
            {
                if (instance == null) // double check locking 
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                             
                return instance;
            }*/

            get
            {
                return instanceLazy.Value;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value "+ counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
