using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
        }

        public static void ShowMyText(object state)
        {
            var temp = (string) state;
            temp += $" {Thread.CurrentThread.ManagedThreadId}";
            Console.WriteLine(temp);
        }
    }
}
