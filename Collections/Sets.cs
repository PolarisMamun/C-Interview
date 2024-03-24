using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public static class Sets
    {
        public static void LearnAllSets()
        {
            string[] familyInitials = new string[] { "J", "A", "C", "A" };
            HashSet<string> familyInitialsSet = new HashSet<string>(familyInitials);
            Console.WriteLine("Learn Hash Set");
            foreach (string initial in  familyInitialsSet)
            {
                Console.WriteLine(initial);
            }

            /*
             * The IEnumerable interface is a part of the .NET framework that enables a programmer to iterate over a collection of items. It is the base interface of all non-generic collection types. It provides a simple interface that allows clients to enumerate over a collection sequentially.
             */
            //the IEnumerable interface provides a simple and efficient way of iterating through collections, allowing programmers to focus on other more important tasks
            IEnumerable<string> otherFamilyInitials = new string[] { "B", "D", "E","A" };
            HashSet<string> otherFamilyInitialsSet = new HashSet<string>(otherFamilyInitials);


            //Union returns a new collection containing all the elements from both collections, excluding any duplicates.
            HashSet<string> unionSet = new HashSet<string>(familyInitialsSet);
            var checkUnion = unionSet.Union(otherFamilyInitialsSet);


            //IntersectWith removes any elements from the current collection that are not present in the specified collection.
            HashSet<string> intersectionSet = new HashSet<string>(familyInitialsSet);
            intersectionSet.IntersectWith(otherFamilyInitialsSet);


            //SymmetricExceptWith removes any elements from the current collection that are also present in the specified collection, and adds any elements from the specified collection that are not present in the current collection.
            HashSet<string> differenceSet = new HashSet<string>(familyInitialsSet);
            differenceSet.SymmetricExceptWith(otherFamilyInitialsSet);

            Console.WriteLine("Union:");
            foreach(string initial in unionSet)
            {
                Console.WriteLine(initial);
            }

            Console.WriteLine("Intersection:");
            foreach(string initial in intersectionSet)
            {
                Console.WriteLine(initial);
            }

            Console.WriteLine("Difference:");
            foreach(string initial in differenceSet)
            {
                Console.WriteLine(initial);
            }

        }
    }
}
