using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");

            Task task1 = new Task(()=>
            {
                Work1();
            });
           
            task1.Start();

            Task task2 = new Task(() =>
            {
                Work2();
            });

            task2.Start();

            Task.WaitAll(task1,task2);

            //task1.Start();
            //task1.ContinueWith((p) =>
            //{
            //    Work2();
            //});



           // Thread.Sleep(1000);
            Console.WriteLine("Main Thread finished");
        }


        static void Work1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Work1 finished");
        }

        static void Work2()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Work2 finished");
        }
    }
}
