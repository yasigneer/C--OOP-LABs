using System; // framework library (namespace)
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace Week1_2  // custom or project namespace
{
    //variable scopes

    //int number5 = 5; variables cannot be defined in namespace level blocks


    class Program  //class 
    {
        int number5 = 5; // Global scope for variables

        static readonly int year =5;
        

        //entry point method  (Starting method)
        static void Main1(string[] args) // method 
        {
            int number6 = 5; // Local scope for variables


            /*
            Console.WriteLine(year);
           
            //datatype  nameofdata = value
            int         number1    =    12;
            Console.WriteLine(number1);
            number1 = 13;
            Console.WriteLine(number1);
            //the rule of variable definitions
            //int 1number1 = 12;
            //int number 1 = 12;
            //int num%ber = 123;

            int _number1 = 1;
            int num_ber = 2;
            int number_ = 12;

            float number2 = 123.5f;
            double number3 = 123.5;

            char ch1 = 'a';

            bool isOk = false;
            isOk = true;


            //case sensitive;
            int number5 = 12;
            int Number5 = 13;



            int a = 5;
            //a = "name"; //error   (checked type compile time)

            var b = 56; //anonymous
            //b = "any string";   //error   (checked type compile time)

            dynamic c =5; //dynamics data types
            Console.WriteLine(c * 5);

            c = "Hello";  //no error   (checked type runtime)
           // Console.WriteLine(c * 5);


            const double pi = 3.14; // must be initialized
                                    //pi = 2.24; // cannot be changed

                                  
     

                        */

            //overflow;
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(bool));
            Console.WriteLine(sizeof(char));
            
            //short a = Int32.MaxValue; //overflow
            short b = 15;

            b = 13216;

            dynamic c = "12312321321313";
            b = Convert.ToInt16(c);







        }



    }
    
    



}
