using AsynchronousV2.Classes;
using System;
using System.Threading.Tasks;

namespace AsynchronousV2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Coffee cup = await PourCoffeeAsync();
            Console.WriteLine("Coffee is ready.");

            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = ToastBreadAsync(2);

            Egg eggs = await eggsTask;
            Console.WriteLine("Eggs are ready");
            Bacon bacon = await baconTask;
            Console.WriteLine("Bacon is ready");
            Toast toast = await toastTask;
            await ApplyButterAsync(toast);
            await ApplyJamAsync(toast);
            Console.WriteLine("Toast is ready");

            Juice oj = await PourOJAsync();
            Console.WriteLine("Orange juice is ready");
            Console.WriteLine("Breakfast is ready");
            Console.ReadLine();
        }
        private static async Task<Coffee> PourCoffeeAsync()
        {
            Console.WriteLine("Pouring coffee...");
            await Task.Delay(2000);
            return new Coffee();
        }

        private static async Task<Egg> FryEggsAsync(int quantity)
        {
            Console.WriteLine($"Cracking {quantity} eggs....");
            await Task.Delay(2000);
            return new Egg();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"Frying {slices} bacon slices");
            await Task.Delay(2000);
            return new Bacon();
        }

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            Console.WriteLine($"Putting {slices} slices of bread in the toaster...");
            await Task.Delay(2000);
            Console.WriteLine("Toast is ready.");
            return new Toast();
        }
        private static async Task<Juice> PourOJAsync()
        {
            Console.WriteLine("Pouring orange juice....");
            await Task.Delay(2000);
            return new Juice();
        }
        private static async Task<Toast> ApplyButterAsync(Toast toast)
        {
            Console.WriteLine("Adding butter to the toast....");
            await Task.Delay(2000);
            Console.WriteLine("Butter is applied");
            return toast;
        }

        private static async Task<Toast> ApplyJamAsync(Toast toast)
        {
            Console.WriteLine("Adding jam to the toast....");
            await Task.Delay(2000);
            Console.WriteLine("Jam is applied");
            return toast;
        }
    }
}
