using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread one = new Thread(new ThreadStart(Counting));
            Thread two = new Thread(new ThreadStart(Counting));

            one.Start();
            two.Start();
            one.Join();
            two.Join();
        }

        public static void Counting()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current count: {i} on thread: {Thread.CurrentThread.ManagedThreadId}.");
                Thread.Sleep(1000);
            }
        }
    }
}
