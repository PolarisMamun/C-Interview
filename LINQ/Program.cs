using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        /* LINQ (Language Integrated Query)
         * LINQ is a set of language features in C# that allow you to query and manipulate data from various sources, including arrays, lists, collections, databases, and XML documents. LINQ provides a consistent, declarative syntax for querying data, which makes it easier to write and read code.
         */
        static void Main(string[] args)
        {
            /*LearnLINQ.LINQQueryArray();
            LearnLINQ.LINQQueryList();
            LearnLINQ.FewLINQ();*/

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            List<int> arr = new List<int> { 793810624, 895642170, 685903712, 623789054, 468592370 };
            Program.miniMaxSum(arr);
            Console.ReadLine();
        }

        public static void miniMaxSum(List<int> arr)
        {
            List<long> arrLong = (from a in arr select Convert.ToInt64(a)).ToList();

            long arrLongSum =  arrLong.Sum();
            long arrLongMax = arrLong.Max();
            long arrLongMin = arrLong.Min();

            long minSum = arrLongSum - arrLongMax;
            long maxSum = arrLongSum - arrLongMin;

            Console.WriteLine(minSum + " " + maxSum);
        }

    }
}
