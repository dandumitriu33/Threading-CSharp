using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingleInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mut = null;
            const string mutexName = "RUNMEONLYONCE";

            while (1 == 1)
            {
                try
                {
                    mut = Mutex.OpenExisting(mutexName);
                }
                catch (WaitHandleCannotBeOpenedException)
                {
                    Console.WriteLine("Mutex does not exist.");
                    Thread.Sleep(1000);
                    Mutex RUNMEONLYONCE = new Mutex();
                }
            }

            mut.ReleaseMutex();
            mut.Dispose();

        }
    }
}
