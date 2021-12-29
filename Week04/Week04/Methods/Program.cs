using System;

namespace Methods
{
    class Program
    {
        static int x = 5;
        static int y = 6;



        //method

        //type name (parameters are optional)
        static void Main(string[] args)
        {

            #region Method Types

            //Console.WriteLine("Hello World!");  //body/ algorithm or logic written here...

            //Sum1();
            //Sum2(5,6);

            //int res0 = Sum3();

            //Console.WriteLine(res0);

            //int res = Sum4(5, 6);

            //Console.WriteLine(res);

            #endregion

            #region Optional Parameters





            int res1 = Sum(1, 2, 3);
            Console.WriteLine(res1);

            int res2 = Sum(1, 2);
            Console.WriteLine(res2);


            int res3 = Sum(1);
            Console.WriteLine(res3);

            int res4 = Sum();
            Console.WriteLine(res4);
            #endregion

            #region Variable  Numbers of Input parameters.
            Console.WriteLine(Sum5());
            Console.WriteLine(Sum5(1, 2, 3, 4));
            Console.WriteLine(Sum5(1, 2, 3, 4, 0, 98, 99));
            #endregion

            #region Random order/named parameters

            Console.WriteLine(Sum6(1, 2, 3)); //classical call
            Console.WriteLine(Sum6(x: 1, y: 2, z: 3)); //with parameters name call
            Console.WriteLine(Sum6(z: 3, y: 2, x: 1)); //with parameters name call

            #endregion

            #region Method Overloading

            Console.WriteLine(Multiply(1.0, 2.0, 5.56));


            #endregion

            #region Recurvie Methods

            Console.WriteLine(Factorial(5));

            #endregion
        }

        #region Recurvie Methods

        static int Factorial(int n)
        {
            if (n == 0)  //stop point
                return 1;

            return n * Factorial(n - 1); //recursively works
        }


        #endregion

        #region Method Overloading

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Multiply(int x, int y, int z) //method signature: MethodName(input parameters)
        {
            return x * y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Multiply(double x, double y, double z)
        {
            return x * y;
        }


        #endregion


        #region Random order/named parameters
        static int Sum6(int x, int y, int z)
        {
            Console.WriteLine($"x : {x}");
            Console.WriteLine($"x : {y}");
            Console.WriteLine($"x : {z}");
            return x + y + z;
        }



        #endregion


        #region Variable  Numbers of Input parameters.

        static int Sum5(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;

        }

        #endregion


        #region Optional Parameters
        //optional parameters/ if no supplied parameters value it takes default assigned one.
        static int Sum(int x = 0, int y = 0, int z = 0)
        {
            return x + y + z;
        }



        #endregion


        #region Method Types


        //1.
        //method signatures/styles
        //type: void,  no parameters, no return type
        //not a good method when we are coding as functional programming
        static void Sum1() //not reusable
        {
            Console.WriteLine(x + y);
        }


        //2.
        //method signatures/styles
        //type: void,  with parameters, no return type
        //it is good method when we are coding as functional programming

        static void Sum2(int a, int b) //is reusable
        {
            Console.WriteLine(a + b);
        }

        //3.
        //method signatures/styles
        //type: int,  no parameters, with  return type
        //it is not a good method when we are coding as functional programming

        static int Sum3() //not reusable
        {
            return x + y;
        }

        //4.
        //method signatures/styles
        //type: int,  with parameters, with  return type
        //it is a good method when we are coding as functional programming

        static int Sum4(int a, int b) // reusable
        {
            return a + b;
        }


        #endregion




    }
}
