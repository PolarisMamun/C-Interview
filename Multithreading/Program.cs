using System;
using System.Threading;

namespace Multithreading
{
    public class Program
    {
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the child thread");
            Thread childThread = new Thread(childref)
            /*{
                Name = "ChildThread",
                Priority = ThreadPriority.BelowNormal,
                IsBackground = true
            }*/;
            childThread.Start();
            Console.ReadLine();
        }

        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }
        
    }
}
