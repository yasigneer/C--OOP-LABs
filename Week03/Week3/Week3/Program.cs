using System;
using System.Runtime.InteropServices;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //type conversion
            //int -->double
            //double -- > int
            //string --> int, double
            //int, double ---> string
            //object --> int, string etc.

            /*
            //1 implicit type conversion
            int x1 = 123;

            //double  <---   int
            double y1 = x1; //implicit type conversion

            // int z1 = y1;


            //explicit type conversion (cast op.)
            int z1 = (int)y1;


            //boxing and unboxing
            object o = "Aydın";
            o = 123;
            o = 123.5;
            o = false;

            object data = 123;
            int data1 = (int)data;



            // Operators

            //Arithmetic ops.  +, -, *, /, %,  will produce numbers
            Console.WriteLine("Arithmetic ops.");
            int a1 = 12;
            int a2 = 6;

            Console.WriteLine(a1 + a2);
            Console.WriteLine(a1 - a2);
            Console.WriteLine(a1 * a2);
            Console.WriteLine(a1 / a2);
            Console.WriteLine(a1 % a2);

            //Relational ops.   <, >, <=, >=, ==, !=  will produce boolean 
            Console.WriteLine("Relational ops.");
            Console.WriteLine(1 >  2);
            Console.WriteLine(1 <= 2);
            Console.WriteLine(1 != 2);
            Console.WriteLine(1 == 2);

            //Logical ops. &&, ||, ! will produce boolean
            Console.WriteLine("Logical ops.");
            Console.WriteLine((1 > 2) || (2>-1));
            Console.WriteLine((1 <= 2) && ( 0 >-2));
            Console.WriteLine(!(1 != 2));
            */

            /*
            //Assignment ops. =, +=, -=, /=, *=, %=
            int p1 = 0;
            Console.WriteLine(p1);
            p1 = 3;
            Console.WriteLine(p1);
            p1 = p1 + 1;
            Console.WriteLine(p1);
            p1 += 4; //p1 = p1+4;
            Console.WriteLine(p1);
            p1 -= 4; //p1 = p1-4;
            Console.WriteLine(p1);
            p1 *= 4; //p1 = p1*4;
            Console.WriteLine(p1);
            p1 /= 4; //p1 = p1/4;
            Console.WriteLine(p1);
            p1 %= 4; //p1 = p1%4;
            Console.WriteLine(p1);


            //Unary ops.  ++, --  increment and decrement 
            p1++; //p1 = p1 + 1; //increase after
            ++p1; //p1 = p1 + 1; //increase before

            int v1 = 1, v2 = 1;
            Console.WriteLine(v1++);
            Console.WriteLine(v1);
            Console.WriteLine(++v2);
            Console.WriteLine(v2);

            p1--; //p1 = p1 - 1; //decrease after
            --p1; //p1 = p1 + 1; //decrease before

            //ternary operator, conditional if
            string result = 1 == 2 ? "Yes" : "No";

            if (1==2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            */

            /*
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine(sizeof(bool));

            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(double));
            Console.WriteLine(typeof(decimal));
            Console.WriteLine(typeof(bool));

            object o = 123;
            Console.WriteLine(o.GetType());
            */

            //if (o.GetType() == typeof(int))
            //{
            //    Console.WriteLine("The mathematical op is ok!");
            //    int a1 = (int)o;
            //}
            //else
            //{
            //    Console.WriteLine("Please choose an integer");
            //}

            /*
            if (o.GetType() is int)
            {
                Console.WriteLine("The mathematical op is ok!");
                int a1 = (int)o;
            }
            else
            {
                Console.WriteLine("Please choose an integer");
            }


            object o1 = "132";
            var n1 = o1 as string;
            var n2 =(string) o1;
            */

            /*
            int[] list = new int[3] { 1, 2, 3 }; //is limited size 1D array
            int[,] matrix2d = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 5 }
            }; //is limited size 2D array

            int[,,] matrix3D = new int[2, 2, 3]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 5 }
                },
                {
                    { 1, 2, 3 },
                    { 4, 5, 5 }
                }
            }; //is limited size 3D array
            */


            //primitive types cannot be null
            //int n1 = null;
            //double d1 = null;

            /*
            //primitive types can be null only with ?
            int? n1 = null;
            double? d1 = null;

            //reference types can be null
            string name = null;
            object o1 = null;

            int[] list = null;
            */



            //control statements

            /*
            int x = 5;
            int y = 5;


            if (x>y)
            {
                Console.WriteLine(x);
            }
            else if (x < y)
            {

                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("Equals");
            }
            */

            /*
            var weekDay = "Sunday";

            switch (weekDay)
            {
                case "Monday":
                    Console.WriteLine($"Do {weekDay} job");
                    //.....
                    break;
                case "Tuesday":
                    Console.WriteLine($"Do {weekDay} job");
                    break;
                case "Wednesday":
                    Console.WriteLine($"Do {weekDay} job");
                    break;
                case "Thursday":
                    Console.WriteLine($"Do {weekDay} job");
                    break;
                case "Friday":
                    Console.WriteLine($"Do {weekDay} job");
                    break;
                case "Saturday":
                    Console.WriteLine($"Do {weekDay} job");
                    break;
                case "Sunday":
                    Console.WriteLine($"Do {weekDay} job");
                    break;

                default:
                    Console.WriteLine($"Wrong day name: {weekDay}");
                    break;
             }


            */



            //control flows / loops

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int[,] matrix =
            {
                {1, 2, -5}, 
                {3, 4, -6}
            };

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write( $"{matrix[i, j]} ");
            //    }

            //    Console.WriteLine();
            //}

            int rowNum =0;
            int colNum = 0;

            //while (rowNum< matrix.GetLength(0))
            //{
            //    while (colNum < matrix.GetLength(1))
            //    {
            //        Console.Write($"{matrix[rowNum, colNum]} ");
            //        colNum++;
            //    }

            //    colNum = 0;
            //    rowNum++;
            //    Console.WriteLine();
            //}

            //rowNum = 0;
            //colNum = 0;

            //do
            //{
            //    do
            //    {
            //        Console.Write($"{matrix[rowNum, colNum]} ");
            //        colNum++;
            //    } while ((colNum < matrix.GetLength(1)));

            //    colNum = 0;
            //    rowNum++;
            //    Console.WriteLine();
            //}
            //while (rowNum < matrix.GetLength(0)) ;


            //int counter = 0;

            //comeHere:

            //Console.WriteLine("sdfsafd");
            //counter++;

            //if (counter<10)
            //{
            //    goto comeHere;
            //}


            /*
            //infinite loops

            //continue and break
            int upperLimit = 100;
            int counter = 0;
            for (; ; )
            {
                if (counter%2 ==0)
                {
                    Console.WriteLine(counter);
                    counter++;
                }
                else
                {
                    counter++;
                    continue;
                }    
                

                if (counter++ > upperLimit-1)
                {
                    break;
                }
                
            }

            //while (true)
            //{
            //    Console.WriteLine("Something");
            //}
            */


            /*
            //about string 

            string name1 = null;

            string name2 = "Aydın";

            name2 = "Mehmet";

            //string is immutable

            string name3 = "Aydın"; //in heap

            char[] name4 = {'A', 'y', 'd', 'ı', 'n'}; //in stack

            name3[0] = 'B'; //immutable
            name3 = "Bydın";

            name4[0] = 'A';  //mutable
            */



            string name1 = "Uygar";

            string name2 = "Uygar";

            Console.WriteLine(name1 == name2);
            Console.WriteLine(name1.Equals(name2));

            string text = "Hello my friends!";

            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.Replace("e", "*"));
            Console.WriteLine(text.Split(" ")[0]);
            Console.WriteLine(text.Contains("my"));
            Console.WriteLine(text.Substring(0, 3));
          


        }
    }
}
