using System;
using System.Collections.Generic;

namespace ArraysCollections
{
    /*
     * the difference between arrays and lists in C#.
     * Arrays and lists are both used to store collections of data, but they differ in how they are implemented and used in memory.
     * An array is a fixed-size sequential collection of elements of the same type. It is stored in contiguous memory locations, 
     * which means that all the elements of the array are stored next to each other in memory. To declare an array, you need to specify the type of elements it will hold and its length
     * This creates an array of 5 integers. Once an array is created, its size cannot be changed.
     * int[] numbers = new int[5];
     * 
     * a list is a dynamic collection of elements of the same type. It is stored in non-contiguous memory locations, 
     * which means that the elements of the list can be scattered in memory. To declare a list, you need to specify the type of elements it will hold
     * List<int> numbers = new List<int>();
     * This creates an empty list of integers. You can add and remove elements from a list dynamically, which means that its size can change at runtime.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            Begin:
            // Declare and initialize an array of integers
            int[] myArray = {10, 20, 30,40,50};

            // Access elements of the array using index notation

            Console.WriteLine("First element: " + myArray[0]);
            Console.WriteLine("Last element: " + myArray[myArray.Length - 3]);

            // Iterate over the array using a for loop

            for(int i =0; i< myArray.Length; i++)
            {
                Console.WriteLine("Element at index " + i + " :" + myArray[i]);
            }


            // Modify an element of the array
            myArray[0] = 100;
            
            Console.WriteLine("First element after modification : " + myArray[0]);

            // Create a copy of the array using the Clone method

            int[] copyArray = (int[])myArray.Clone();

            // Modify the copy of the array
            copyArray[0] = 200;

            // Compare the original and copied arrays

            for(int i = 0; i <myArray.Length; i++)
            {
                Console.WriteLine("myArray[" + i + "] == copyArray[" + i + "]: " + (myArray[i] == copyArray[i]));
            }
            ListTest();
            Console.ReadLine();
            goto Begin;
        }

        static void ListTest()
        {
            // Declare and initialize a list of strings
            List<string> myList = new List<string>() { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Access elements of the list using index notation

            Console.WriteLine("First Element: " + myList[0]);
            Console.WriteLine("Last Element: " + myList[myList.Count - 1]);

            // Iterate over the list using a foreach loop

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i<myList.Count; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + myList[i]);
            }

            // Modify an element of the list
            myList[0] = "Kiwi";
            Console.WriteLine("First element after modification: " + myList[0]);

            // Add an element to the end of the list
            myList.Add("Guava");

            // Insert an element at a specific position

            myList.Insert(1, "Lemon");

            // Remove an element from the list
            myList.Remove("Cherry");
            Console.WriteLine("After removed: " + myList[2]);
            myList.RemoveAt(myList.Count - 1);
            Console.WriteLine("After removed: " + myList[4]);
            // Clear the list
            myList.Clear();
        }
    }
}
