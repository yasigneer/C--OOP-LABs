using System;

namespace SomeUsefulClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    RollDice();
            //}

            //var myBirthDay = new DateTime(1979, 2, 19);

            //CalculateWhichDayIBorn(myBirthDay);

           // DoWork(10000);

           Console.WriteLine(SquareSum());


        }

        static void RollDice()
        {
            Random random = new Random();

            var dice1 = random.Next(1, 7); //1---6
            var dice2 = random.Next(1, 7); //1---6

            Console.WriteLine($"({dice1},{dice2})");
        }

        static void CalculateWhichDayIBorn(DateTime dt)
        {

            var dayName = dt.DayOfWeek.ToString();
            Console.WriteLine(dayName);

        }

        static void DoWork(int count)
        {
            var start = DateTime.Now;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Job"+ i +". Completed");
            }

            var end = DateTime.Now;

            TimeSpan ts = end - start;

            Console.WriteLine("Time taken: "+ ts.TotalMilliseconds);
        }


        static double SquareSum()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            return Math.Pow(x,2) +Math.Pow(y,2);
        }

    }
}
