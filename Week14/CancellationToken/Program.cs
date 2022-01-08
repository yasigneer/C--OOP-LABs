using System;
using System.Threading;
using System.Threading.Tasks;

namespace CancellationToken
{
    class Program
    {
        static void Main(string[] args)
        {
            Work1();
            Work2();

            Thread.Sleep(5000);
            _cancellationTokenSource.Cancel();
            Console.Read();
        }

        static readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        static async Task Work1()
        {
            
            Random rnd = new Random();
            await Task.Run(() =>
            {
                int i = 1;
                while (true)
                {
                    Thread.Sleep(rnd.Next(0, 2000));
                    Console.WriteLine($"Work1 Executed-{++i}");

                    if (_cancellationTokenSource.IsCancellationRequested)
                    {
                        Console.WriteLine("Work1 Terminated****************");
                       break;
                       
                    }
                   
                }
            });
        }
        static async Task Work2()
        {
            Random rnd = new Random();
            await Task.Run(() =>
            {
                int i = 1;
                while (true)
                {
                    Thread.Sleep(rnd.Next(0, 2000));
                    Console.WriteLine($"Work2 Executed-{++i}");

                    if (_cancellationTokenSource.IsCancellationRequested)
                    {
                        Console.WriteLine("Work2 Terminated**************");
                        break;
                    }
                }
            });
        }
    }
}
