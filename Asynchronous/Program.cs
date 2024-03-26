using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class Program
    {
        /*
         * Asynchronous programming is a way to write code that can run multiple tasks simultaneously without blocking the main thread. This is particularly useful when performing I/O-bound operations, such as accessing a database, reading files, or making network requests.
         */

        /*
         * One way to achieve asynchronous programming in C# is by using the async and await keywords. The async keyword is used to declare a method that synchronously starts a task and returns a Task or Task<T> object, which can be awaited. The await keyword is used to asynchronously wait for the completion of a task.
         */

        /*
         * Asynchronous programming is a way to write non-blocking, concurrent code that can run multiple operations at the same time. This is especially useful in I/O-bound operations, such as reading/writing files, making network requests, or waiting for user input, where the program can be doing other things while it waits for the I/O operation to complete.
         */
        public static async Task Main(string[] args)
        {
            await FetchDataAsync();

            Console.WriteLine("Program execution continues while data is being fetched...");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Doing some other work {i}");
                await Task.Delay(5000);
            }
            Console.ReadLine();
        }

        public static async Task FetchDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://www.linkedin.com/feed/");

                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Data fetched successfully");
                        Console.WriteLine(data);
                    }
                    else
                    {
                        Console.WriteLine("Failed to fetch data. Status code: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
