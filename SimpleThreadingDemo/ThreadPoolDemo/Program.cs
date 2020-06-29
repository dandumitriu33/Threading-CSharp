using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(ShowMyText);
            ThreadPool.QueueUserWorkItem(ShowMyText);
            ThreadPool.QueueUserWorkItem(ShowMyText);
            ThreadPool.QueueUserWorkItem(ShowMyText);
            ThreadPool.QueueUserWorkItem(ShowMyText);
            ThreadPool.QueueUserWorkItem(ShowMyText);
            ThreadPool.QueueUserWorkItem(ShowMyText);
            ThreadPool.QueueUserWorkItem(ShowMyText);
            ThreadPool.QueueUserWorkItem(ShowMyText);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(1000);

            Console.WriteLine("Main thread exits.");

            Console.WriteLine("Parallel Process Complete.");
            int[] numbers = new int[10] { 23, 31, 44, 22, 54, 23, 65, 76, 37, 88 };
            Parallel.ForEach(numbers, (number) =>
                                    {
                                        if (number > 0)
                                        {
                                            Console.WriteLine($"Number {number} is positive. Process used thread: {Thread.CurrentThread.ManagedThreadId}.");
                                            Thread.Sleep(1000);
                                        }
                                    });
            Console.WriteLine("Parallel Process Complete.");
        }

        public static void ShowMyText(object state)
        {
            var temp = (string) state;
            temp += $" {Thread.CurrentThread.ManagedThreadId}";
            Console.WriteLine(temp);
        }
    }
}
