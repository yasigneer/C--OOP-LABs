using System;

namespace SrtuctDataType
{
    class Program
    {
        

        static void Main(string[] args)
        {
            

            MyClass c =new MyClass();
            c.a = 5;

            MyStruct s = new MyStruct ();
            s.a = 5;
          

            Console.WriteLine(s.a);
            Console.WriteLine(c.a);

            DoAnything(c, s);

            Console.WriteLine(s.a);
            Console.WriteLine(c.a);

        }

        static void DoAnything(MyClass myClass, MyStruct myStruct)
        {
            myClass.a = 25;
            myStruct.a = 25;
        }
    }

    class C
    {

    }

    struct S
    {

    }

    interface IInterface
    {
        void DoWork();
    }



    class MyClass : IInterface
    {
        public static int b;

        public int a;

        public int A { get; set; }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public void Method()
        {

        }
    }

    //may have members instance or static like a class
    //cannot inherits any class or struct
    //can implement interfaces
    //cannot be inherited by any class or struct
    //they are value types
    struct MyStruct : IInterface
    {
      

        public static int b;

        public int a;

        public int A { get; set; }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public void Method()
        {

        }
    }
}
