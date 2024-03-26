using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class LearnLINQ
    {
        public static void LINQQueryArray()
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};

            // Find all the even numbers
            /*
             * The query syntax uses the from keyword to define the source of the data, 
             * the where keyword to filter the data, and the select keyword to project the data into a new form.
             */
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;
            var oddNumbers = from number in numbers
                             where number % 2 == 1
                             select number;

            Console.WriteLine("Print Even Number");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Print Odd Number");
            foreach(int number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void LINQQueryList()
        {
            List<string> words = new List<string> { "apple","banana","cherry","orange","grape"};
            // Find all the words that contain the letter "a"
            var wordWithA = from word in words
                            where word.Contains("a")
                            select word;

            // Print the words that contain the letter "a"
            Console.WriteLine("Print word that contain the letter a");
            foreach (string word in wordWithA)
            {
                Console.WriteLine(word);
            }
        }

        public static void FewLINQ()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Doe", TotalSales = 5000, LastOrderDate = DateTime.Parse("2022-01-01") },
                new Customer { Id = 2, Name = "Jane Smith", TotalSales = 15000, LastOrderDate = DateTime.Parse("2022-05-15") },
                new Customer { Id = 3, Name = "Jim Brown", TotalSales = 7000, LastOrderDate = DateTime.Parse("2022-03-30") },
                new Customer { Id = 4, Name = "Mary Johnson", TotalSales = 8000, LastOrderDate = DateTime.Parse("2022-08-01") },
                new Customer { Id = 5, Name = "Mark Jones", TotalSales = 9000, LastOrderDate = DateTime.Parse("2022-04-12") }
            };

            var highlyActiveCustomers = customers
                .Where(c => c.TotalSales > 7000)
                .OrderByDescending(c => c.TotalSales)
                .Take(2);

            Console.WriteLine("Learn Where , OrderByDescending , Take  LINQ");
            foreach (var customer in highlyActiveCustomers)
            {
                Console.WriteLine($"{customer.Name} - {customer.TotalSales}");
            }

            var selectByName = customers
                .OrderBy(c=>c.Name)
                .Select(c=> new {c.Name,c.TotalSales})
                .ToList();
            Console.WriteLine("\nLearn OrderBy , Select , ToList  LINQ");
            foreach (var customer in selectByName)
            {
                Console.WriteLine($"{customer.Name}: {customer.TotalSales}");
            }

            var customersByLastOrderDate = customers
                .GroupBy(c=>c.LastOrderDate.Month)
                .Select(g=> new {Month = g.Key,Customers = g})
                .ToList();

            /*
             * Select(g=> new {Month = g.Key,Customers = g}) transforms the grouped Customer objects using the Select method, which creates a sequence of new objects that are a subset of the original data. In this case, each grouped Customer objects is transformed into an anonymous object with two properties:
                Month: the key of the group, representing the month value of the LastOrderDate
                Customers: the collection of Customer objects that belong to the group, g
             */

            Console.WriteLine("\nLearn GroupBy , Select , ToList  LINQ");
            foreach (var group in customersByLastOrderDate)
            {
                Console.WriteLine($"Month: {group.Month}");
                foreach(var customer in group.Customers)
                {
                    Console.WriteLine($"\t{customer.Name}");
                }
            }
        }
    }
}
