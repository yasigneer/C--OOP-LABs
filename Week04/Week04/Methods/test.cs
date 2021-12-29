using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class test
    {

        //static void Sum1()
        //{
        //    Console.WriteLine(x + y);
        //}

        static void Sum2(int a, int b) //is reusable
        {
            Console.WriteLine(a + b);
        }

        //static int Sum3() //not reusable
        //{
        //    return x + y;
        //}


        static int Sum4(int a, int b) // reusable
        {
            return a + b;
        }
    }
}
