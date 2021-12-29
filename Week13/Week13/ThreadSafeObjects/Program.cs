using System;
using System.Threading;

namespace ThreadSafeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process Started");
            Account2 account = new Account2("Aydın", 1000);
            Console.WriteLine($"First Balance: {account.Balance}");

            //for (int i = 0; i < 2000; i++)
            //{
            //    account.WithDraw(100);
            //    account.Deposit(100);
            //}

            for (int i = 0; i < 200; i++)
            {
                Thread thread2 = new Thread(account.Deposit);
                thread2.Start(100);

                Thread thread1 = new Thread(account.WithDraw);
                thread1.Start(100);
            }

            account.Deposit(100);
            account.WithDraw(100);

            Thread.Sleep(10000);
            Console.WriteLine($"Last Balance: {account.Balance}");
        }
    }


    //thread safe class with lock keyword
    class Account
    {
        public Account(string owner, decimal balance)
        {
            Balance = balance;
            Owner = owner;
        }

        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public void WithDraw(object amount)
        {
            lock (this)
            {
                Balance = Balance - Convert.ToDecimal(amount);
            }
        }

        public void Deposit(object amount)
        {
            lock (this)
            {
                Thread.Sleep(100);
                Balance = Balance + Convert.ToDecimal(amount);
            }

        }

    }

    //thread safe class with Mutex object
    class Account2
    {
        public Account2(string owner, decimal balance)
        {
            Balance = balance;
            Owner = owner;
            mutex = new Mutex();
        }

        private Mutex mutex;
        
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public void WithDraw(object amount)
        {
            Thread.Sleep(5);

            mutex.WaitOne();

            Balance = Balance - Convert.ToDecimal(amount);

            mutex.ReleaseMutex();
        }
        public void Deposit(object amount)
        {
            mutex.WaitOne();

            Thread.Sleep(10);
            Balance = Balance + Convert.ToDecimal(amount);

            mutex.ReleaseMutex();
        }

    }
}
