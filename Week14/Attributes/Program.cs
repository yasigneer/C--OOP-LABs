#define Test
using System;
using System.Diagnostics;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.WhoAreYou();
            //Console.WriteLine("Hello World!");

            Type info = typeof(Student);

            var attributes = info.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute.ToString());
            }

        }

        [MyClassInfo(Developer = "Aydın", Version = 1)]
        [Serializable]
        [Obsolete("This section will be replaced in the future version")]
        class Student
        {
            public Student()
            {

            }

            public Student(int x)
            {

            }

            public int id;
            public string name;

            public string Address { get; set; }
            public DateTime BirthDate { get; set; }

            [Conditional("Test")]
            public void WhoAreYou()
            {
                Console.WriteLine("I am a student class");
            }


            public void M1(string x, int n)
            {
                Console.WriteLine($"I am M1 {x}:{n}");
            }

            public void M2()
            {
                Console.WriteLine("I am M1");
            }
        }


        class MyClassInfo : Attribute
        {
            public int Version;
            public string Developer;
        }
    }
}
