using System;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    class Program
    {
        //method signature........
        public delegate T MathDelegate<T>(T x, T y);

        static void Main(string[] args)
        {
            //var method1 = new MathDelegate<int>(Sum);
            //var method2 = new MathDelegate<double>(Sum);

            ////Console.WriteLine(method1(1, 2));
            ////Console.WriteLine(method2.Invoke(1, 2));

            ////Console.WriteLine(MethodSelector(Sum, 5, 6));
            ////Console.WriteLine(MethodSelector(Product, 5, 6));

            //var myMethod = GetMethod(2);
            //Console.WriteLine(myMethod.Invoke(5, -5));

            //var result = MethodSelector((int a, int b) => a + b, 5, 4);

            //var methodSeries =new  MathDelegate<int>(Sum);
            //methodSeries += Product;
            //methodSeries += Divide;
            //methodSeries += Subtract;

            //methodSeries.Invoke(1, 5);

            //void type generic delegate
            //Action<int,int> myMethod1 = Sum1;

            ////int type delegate
            //Func<int,int, int> myMethod2 = Sum;

            //myMethod1.Invoke(1,2);
            //myMethod2.Invoke(3, 6);

            //DoOperation(Sum1,1,3);
            //DoOperation(Product, 1, 3);

            //Console.WriteLine(GetMethod().Invoke(10,5));


            Action<int, int> GetSquare1 = (x, y) =>
                   {
                       Console.WriteLine(x * x + y * y);
                   };

            GetSquare1(1, 5);
            GetSquare(1, 5);

        }


        static void GetSquare(int x, int y)
        {
            Console.WriteLine(x * x + y * y);
        }

        static Func<int, int, int> GetMethod()
        {
            return Divide;
        }

        static void DoOperation(Action<int, int> method, int x, int y)
        {
            method.Invoke(x, y);
        }
        static void DoOperation(Func<int, int, int> method, int x, int y)
        {
            Console.WriteLine(method.Invoke(x, y));
        }

        static void Sum1(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static MathDelegate<int> GetMethod(int methodId)
        {
            if (methodId == 1)
                return Sum;
            if (methodId == 2)
                return Subtract;
            if (methodId == 3)
                return Divide;

            return Product;



        }

        static T MethodSelector<T>(MathDelegate<T> method, T x, T y)
        {
            return method(x, y);
        }

        static int Sum(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }
        static double Sum(double x, double y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
            return x - y;
        }
        static int Divide(int x, int y)
        {
            Console.WriteLine(x / y);
            return x / y;
        }
        static int Product(int x, int y)
        {
            Console.WriteLine(x * y);
            return x * y;
        }
    }
}
