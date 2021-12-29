using System;
using System.Collections.Generic;

namespace Polymorphism
{


    class Program
    {
        static void Main(string[] args)
        {
            //var loggers = new List<Logger>();

            //loggers.Add(new FileLogger());
            //loggers.Add(new DbLogger());
            //loggers.Add(new FileLogger());
            //loggers.Add(new FileLogger());
            //loggers.Add(new DbLogger());

            //foreach (var logger in loggers)
            //{
            //    logger.GetLog();
            //}

            //WriteLog(new FileLogger());
            //WriteLog(new DbLogger());


            A[] list = new A[3];

            list[0] = new A();
            list[1] = new B();
            list[2] = new C();

            foreach (var item in list)
            {
                item.WhoAmI();
            }

        }

        static void WriteLog(Logger logger)
        {
            logger.GetLog();
        }

    }

    abstract class Logger
    {
        public abstract void GetLog();
    }

    class FileLogger : Logger
    {
        public override void GetLog()
        {
            Console.WriteLine("event Logged in file...");
        }
    }

    class DbLogger : Logger
    {
        public override void GetLog()
        {
            Console.WriteLine("event Logged in Db...");
        }
    }



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var loggers = new List<ILogger>();

    //        loggers.Add(new FileLogger());
    //        loggers.Add(new DbLogger());
    //        loggers.Add(new FileLogger());
    //        loggers.Add(new FileLogger());
    //        loggers.Add(new DbLogger());

    //        foreach (var logger in loggers)
    //        {
    //            logger.GetLog();
    //        }


    //    }
    //}


    //interface ILogger
    //{
    //    void GetLog();
    //}

    //class FileLogger : ILogger
    //{
    //    public void GetLog()
    //    {
    //        Console.WriteLine("event Logged in file...");
    //    }
    //}

    //class DbLogger : ILogger
    //{
    //    public void GetLog()
    //    {
    //        Console.WriteLine("event Logged in Db...");
    //    }
    //}


    //polymorphism by classes

    class A
    {
        public virtual void WhoAmI()
        {
            Console.WriteLine("Am A class");
        }
    }

    class B:A
    {
        public override void WhoAmI()
        {
            Console.WriteLine("Am B class");
        }
    }

    class C :B
    {
        public override void WhoAmI()
        {
            Console.WriteLine("Am C class");
        }
    }

}
