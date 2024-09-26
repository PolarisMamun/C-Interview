using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Program
    {

        public delegate bool MathCustom(int age);


        static void Main(string[] args)
        {

            Func<int, int, bool> func1 = (int x, int y) => x > 1;


            Action<int, int> func2 = (x, y) => Console.WriteLine(x + y);


            var result = GetProperAgePerson(x => x > 10);
        }

        public static bool CustomAgeFilter(int age)
        {
            return age > 10;
        }

        public static List<Person> GetProperAgePerson(MathCustom predicate)
        {
            List<Person> result = new List<Person>()
            {
                new Person()
                {
                    Age = 10
                },
                new Person()
                {
                    Age = 20
                },
                new Person()
                {
                    Age = 30
                }
            };

            List<Person> finalResult = new List<Person>();
            foreach (var item in result)
            {
                var tempResult = predicate.Invoke(item.Age);
                if (tempResult)
                {
                    finalResult.Add(item);
                }

            }

            return finalResult;
        }


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }


    }


    class Person
    {
        public int Age { get; set; }
    }


}