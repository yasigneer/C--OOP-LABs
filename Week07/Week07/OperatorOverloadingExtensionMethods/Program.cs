using System;
using Microsoft.CSharp;

namespace OperatorOverloadingExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Read();
            //extension methods are extend any data type by adding new methods from outside
            //string name = "Aydın";

            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.Reverse());

            //int a = 4.Pow(2);
            //Console.WriteLine(a);

            Complex c1 = new Complex { A = 1, B = 1 }; // 1 + i
            Complex c2 = new Complex { A = 1, B = 2 }; // 1 + 2*i

            Complex c3 = c1.Sum(c2);

           // Console.WriteLine(c3);

            Complex c4 = c1 + c2;

            Console.WriteLine(c4);

           // Console.WriteLine(c1 - c4);

            Console.WriteLine(2 * c4);

            Console.WriteLine(c4 * 2);

            object co1 = new Complex { A = 1, B = 1 };//boxing

            Console.WriteLine(((Complex)co1).A); //unboxing// time and resource consume

            //Boxing




        }
    }
    class Complex
    {
        public double A { get; set; }
        public double B { get; set; }
        public override string ToString()
        {
            if (B < 0)
            {
                if (B == -1)
                    return $"{this.A} - i";

                return $"{this.A} - {-this.B}i";
            }
            else if (B > 0)
            {
                if (B == 1)
                    return $"{this.A} + i";

                return $"{this.A} + {this.B}i";
            }


            else
            {
                return $"{this.A}";
            }


        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex
            {
                A = c1.A + c2.A,
                B = c1.B + c2.B,
            };
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex
            {
                A = c1.A - c2.A,
                B = c1.B - c2.B,
            };
        }
        public static Complex operator *(double r, Complex c)
        {
            return new Complex
            {
                A = r*c.A,
                B = r*c.B
            };
        }
        public static Complex operator *(Complex c,double r)
        {
            return new Complex
            {
                A = r * c.A,
                B = r * c.B
            };
        }
    }
    static class MyExtesions
    {
        public static Complex Sum(this Complex c1, Complex c2)
        {
            return new Complex
            {
                A = c1.A + c2.A,
                B = c1.B + c2.B,

            };

        }
        public static int Pow(this int x, int pow)
        {
            int powerResult = 1;
            for (int i = 1; i <= pow; i++)
            {
                powerResult = powerResult * x;
            }

            return powerResult;
        }

        public static string Reverse(this string word)
        {
            int len = word.Length;
            string reversed = "";

            for (int i = len - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            return reversed;


        }
    }
}

namespace Namespace1
{

}
