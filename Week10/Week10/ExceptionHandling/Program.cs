using System;
using System.Data;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = {1, 2, 3, 4};

            //try
            //{
            //    //the code that will run
            //    for (int i = 0; i < 8; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    //catching exception
            //}


            //Console.WriteLine("Operation 1 started");

            //try
            //{
            //    int x = 0;
            //    int y = 10/x;

            //    Console.WriteLine("Operation 2 completed");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception occurred... ");
            //}


            //Console.WriteLine("very important Operation started");





            //try
            //{
            //    int x = 0;
            //    int y = 10 / x;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("Enter your age: ");

            //try
            //{
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"You age entered is: {age}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Age is not an integer...");
            //    Console.WriteLine(e.Message);

            //}

            //Console.WriteLine("Another operation started");


            //try
            //{
            //    int x = 6;
            //    int y = 10 / x;

            //    //int[] numbers = { 1, 2, 3, 4 };

            //    //for (int i = 0; i < 10; i++)
            //    //{
            //    //    Console.WriteLine(numbers[i]);
            //    //}

            //    //.....

            //    // throw new Exception("my arbitrary exception");

            //    Console.WriteLine("Successfully completed");
            //}
            //catch (ArithmeticException e)
            //{
            //    Console.WriteLine(e.Message);

            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);

            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Handling completed... do any job here that you need...");
            //}


            Console.WriteLine("Enter your age: ");

            try
            {
                int age = 0;
                try
                {
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    throw new NoANumber(age);
                }

                if (age < 25 || age > 150)
                {
                    throw new InvalidAgeException(age);
                }
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NoANumber e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //IF YOU NEED SOMETHING TO DO
            }
        }
    }

    class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {

        }

        public InvalidAgeException(int age) : base($"Invalid age range must be in the range 25 - 150, entered: {age}")
        {

        }
    }
    class NoANumber : Exception
    {
        public NoANumber()
        {

        }

        public NoANumber(object age) : base($"Not a number exception: {age}")
        {

        }
    }
}
