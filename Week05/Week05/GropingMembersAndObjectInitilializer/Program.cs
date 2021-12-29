using System;

namespace GropingMembersAndObjectInitilializer
{
    class Program
    {
        static void TestM1()
        {
            //.....
        }

        static int x = 0;
        static void Main(string[] args)
        {
            //TestM1(); 
            //x = 5;


            #region Object intitializer

            ////standart property setting
            //Student student = new Student();
            //student.id = 1;
            //student.Name = "Ahmet";
            //student.BirthDate = DateTime.Now.AddYears(-10);

            ////object initializer 
            //Student student1 = new Student
            //{
            //    id=2,
            //    Name = "Ayşe",
            //    BirthDate = DateTime.Now.AddYears(11),

            //};

            #endregion

            #region static vs instance members

            MyClass instance1 = new MyClass();
            instance1.a1 = 5;
            instance1.A1 = 6;
            instance1.M1();

            MyClass instance2 = new MyClass();
            instance2.a1 = 5;
            instance2.A1 = 6;
            instance2.M1();

            MyClass.a2 = 5;
            MyClass.A2 = 56;
            MyClass.M2();




            #endregion

            #region Encapsulation example

            TestClass t = new TestClass();
            //a1.a  not reachable// private
            t.a2 = 5;// public
            //t.a3  not reachable //protected
            t.a4 = 6; //internal
            t.a5 = 78;//protected internal

            TestDerivedClass td = new TestDerivedClass();
            td.a2 = 5; //public
            //td.a1 = 6; //not reach private
            // td.a3 = 6; //not reach protected
            td.a4 = 6; //internal
            td.a5 = 78;//protected internal

            #endregion

        }
    }

    #region Encapsulation Example
    //Encapsulation example
    public class TestClass
    {
        private int a1;
        public int a2;
        protected int a3;
        internal int a4;
        protected internal int a5;

        private void M1()
        {
            a1 = 6;//private
            a2 = 3;//public
            a3 = 6;//protected
            a4 = 66;//internal
            a5 = 78;//protected internal
        }

        public void M2()
        {
            a2 = 5;
        }



    }

    //    derived:  baseclass
    public class TestDerivedClass:TestClass 
    {
        void M1()
        {
            // a1 = 1; not reachable //private
            a2 = 6; //public
            a3 = 7; //protected 
            a4 = 99; //internal
            a5 = 78;//protected internal
        }
    }
    #endregion



    public class MyClass
    {
        #region Instance members
        public int a1;
        public int A1 { get; set; }

        public void M1()
        {
            a2 = 5;
            Console.WriteLine("I am an instance member");
        }
        #endregion

        #region Static members
        public static int a2;
        public static int A2 { get; set; }

        public static void M2()
        {
           // a2 = 2;
           // M2();
            Console.WriteLine("I am a static member");
        }


        #endregion
     }

    class Student
    {
        public int id;

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public void M1()
        {

        }
    }
}
