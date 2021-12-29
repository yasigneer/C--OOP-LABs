using System;

namespace TypeOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //getting instance is possible
            RegularClass regularClass = new RegularClass();

            //AbstractClass abstractClass = new AbstractClass(); //can not be instantiate/getting instance impossible

            //StaticClass staticClass = new StaticClass();//impossible to get instance

            SealedClass sealedClass = new SealedClass();//can be got instance

            PartialLongClass partialLongClass = new PartialLongClass();
            

            

        }
    }



    class A:PartialLongClass
    {

    }

    abstract class B
    {

    }

    interface IInterface
    {

    }


    //exactly behaves like regular class
    //can be inhertied
    //can inherit
    //we can get instance
    //can implement interfaces
    partial class PartialLongClass
    {
        public int A { get; set; }

        public void B()
        {

        }
    }

    partial class PartialLongClass
    {
        public int C { get; set; }

        public void D()
        {

        }
    }


    //may have regular members
    //may have static members
    //can inherit abstract or regular clasess
    //can implement interfacess
    //cannot be inherited by any class
    sealed class SealedClass
    {
        public int x;

        public static int y;

        public int X { get; set; }

        public void Method()
        {

        }
    }

    //all members mut be static
    //cannnot inherits any class
    //cannot impelement any interface
    //cannot be inherited
    //cannot implements interfaces
    //cannot have any constructors
    static class StaticClass
    {

        public static int x;

        public static int X { get; set; }

        public static void Method()
        {

        }
    }


    //may have regular members such as regular class
    //may have abstract members/with no bodies
    //can be inherited// if has abstract members they must be overriden
    //can inherit other regular or abstract clasess
    //only can be inherited by other abstract or regular classes
    abstract class AbstractClass : B
    {
        public int x;

        public int X { get; set; }

        public void Method()
        {

        }

        public abstract void Method2();


    }


    //can be inherited
    //can inherit other regular or abstract clasess
    class RegularClass
    {
        public int x;

        public int X { get; set; }

        public void Method()
        {

        }

    }
}

namespace Namespace2
{
    class MyClass
    {

    }
}

namespace Namespace3
{
    class MyClass
    {

    }
}
