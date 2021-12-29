using System;
using System.IO;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //var thread = Thread.CurrentThread;
            //thread.Name = "Main thread";

            //Console.WriteLine(Thread.CurrentThread.Name);
            //Console.WriteLine(thread.IsAlive);

            //Console.WriteLine("Long Process Started....");
            //Thread.Sleep(5000);
            //Console.WriteLine("Long Process Finished....");

            //Console.WriteLine($"{thread.Name} -Started");

            //PrintMessage("Hello");



            //Thread thread1 = new Thread(PrintMessage);
            //thread1.Name = "Sub Thread 1";
            //thread1.IsBackground = false;



            //Thread thread2 = new Thread(PrintMessage);

            //thread2.IsBackground = false;
            //thread2.Name = "Sub Thread 2";

            //thread1.Priority = ThreadPriority.Lowest;
            //thread2.Priority = ThreadPriority.Highest;

            //thread1.Start("Hello 1");

            ////thread1.Join(5000);

            //thread2.Start("Hello 2");
            //thread2.Join(5000);

            //PrintMessage("Hello 1");
            //PrintMessage("Hello 2");
            //Thread.Sleep(5000);
            //Console.WriteLine($"{thread.Name} -Finished");


            //ThreadPool.SetMinThreads(1, 2);
            //ThreadPool.SetMaxThreads(16, 4);

            //WaitCallback wcb = new WaitCallback(DownloadFile);
            //int connectedUser = 10000;

            //for (int i = 0; i < connectedUser; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(wcb, 1);
            //}


            //Thread.Sleep(1000);
            //Console.Read();

            Thread thread = new Thread(CreateFile);
            thread.IsBackground = false;
            thread.Start();
            
            //Thread.Sleep(10000);
            Console.WriteLine("Main Thread finished");
        }

        static void CreateFile()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(2000);
                var path = $"d:\\{DateTime.Now.Ticks}.txt";
                File.Create(path);
            }
        }
        public static void DownloadFile(object message)
        {
            Console.WriteLine($"{message} - {Thread.CurrentThread.GetHashCode()}");
            Thread.Sleep(10);
        }

        //public static void PrintMessage(object message)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{message} - {Thread.CurrentThread.GetHashCode()}" ); 
        //        Thread.Sleep(1000);
        //    }
        //}

    }
}
