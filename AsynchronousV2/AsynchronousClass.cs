using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsynchronousV2.Classes;

namespace AsynchronousV2
{
    public class AsynchronousClass
    {
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
