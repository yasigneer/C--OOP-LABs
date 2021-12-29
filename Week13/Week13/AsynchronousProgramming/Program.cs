using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        private static AutoResetEvent _opSignal = new AutoResetEvent(false);
        static async Task Main(string[] args)
        {
            Console.WriteLine("1-Main starts");
            WithdrawMoneyAsync(123);
            SendVerificationSmsAsync(123);

            Thread.Sleep(3000);
            Console.WriteLine("5-Main ends");
        }
        static async Task<string> Work1(int n)
        {
            await Task.Run(() =>
             {
                 for (int i = 0; i < n; i++)
                 {
                     Thread.Sleep(10);
                     Console.WriteLine($"Work1 executed {i + 1}");
                 }
             });

            return "0";
        }

        static async Task WithdrawMoneyAsync(int tranId)
        {
            Console.WriteLine("2-Withdraw transaction started....: TranId:" + tranId);
            

            await Task.Run(() =>
            {
                _opSignal.Reset();
                
                Console.WriteLine("Verification Started: TranId:" + tranId);
                _opSignal.WaitOne();
                Console.WriteLine("4-Withdraw transaction finished....: TranId:" + tranId);
            });
        }

        static async Task SendVerificationSmsAsync(int tranId)
        {
            Thread.Sleep(10000);

            await Task.Run(() =>
            {
                //Thread.Sleep(2000);
                Console.WriteLine("3-Message Sent....: TranId:"+tranId);
                _opSignal.Set();
            });
        }
    }


}
