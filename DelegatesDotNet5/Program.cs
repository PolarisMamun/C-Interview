using System;

namespace DelegatesDotNet5
{
    public class Program
    {
        delegate void MyDelegate(int x, int y);
        
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Add);
            MyDelegate myDelegate1 = Add;
            myDelegate += Subtract;
            myDelegate += Multiply;
            myDelegate += Divide;

            myDelegate.Invoke(5, 2);
            Console.ReadLine();
        }
        static void Add(int x, int y)
        {
            Console.WriteLine($"Add: {x} + {y} = {x + y}");
        }
        static void Subtract(int x, int y)
        {
            Console.WriteLine($"Subtract: {x} - {y} = {x - y}");
        }
        static void Multiply(int x, int y)
        {
            Console.WriteLine($"Multiply: {x} * {y} = {x * y}");
        }
        static void Divide(int x, int y)
        {
            Console.WriteLine($"Divide: {x} / {y} = {x / y}");
        }
        static double Add(double x, double y)
        {
            return x * y;
        }
    }
}
