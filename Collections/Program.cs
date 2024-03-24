using System;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Array Example
            int[] myArray = new int[5];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 30;
            myArray[3] = 40;
            myArray[4] = 50;

            Console.WriteLine("Array Example");
            for(int i =0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            //List Example

            List<int> myList = new List<int>();
            
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);

            Console.WriteLine("\n List Example");
            foreach(int item in myList)
            {
                Console.WriteLine(item);
            }

            //Dictionary example
            Dictionary<string,int> myDictionary = new Dictionary<string,int>();
            myDictionary.Add("Apple", 1);
            myDictionary.Add("Banana", 2);
            myDictionary.Add("Cherry", 3);

            Console.WriteLine("\nDictionary Example");

            foreach (KeyValuePair<string,int> entry in myDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}",entry.Key,entry.Value);
            }

            //Set Example

            HashSet<int> mySet = new HashSet<int>();

            mySet.Add(10);
            mySet.Add(20);
            mySet.Add(30);

            Console.WriteLine("\nSet Example");

            foreach(int item in mySet)
            {
                Console.WriteLine(item);
            }
            Sets.LearnAllSets();
            Console.ReadLine();
        }
    }
}
