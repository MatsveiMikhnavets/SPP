using System;
using System.Threading;

namespace SPP1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskQueue taskQueue = new TaskQueue(10);

            for (int i = 0; i < 20; i++)
            {
                taskQueue.EnqueueTask(Test);
            }
        }

        static void Test()
        {
            int k = 0;
            for (int i = 0; i < 1000000; i++)
            {
                k++;
            }
            Console.WriteLine(Thread.CurrentThread.Name);
        }
    }
}