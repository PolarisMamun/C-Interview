using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await FetchDataAsync();

            Console.WriteLine("Program execution continues while data is being fetched...");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Doing some other work {i}");
                await Task.Delay(500);
            }
            Console.ReadLine();
        }

        public static async Task FetchDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");

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
