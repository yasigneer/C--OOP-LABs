using System;
using GropingMembersAndObjectInitilializer;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            TestClass t = new TestClass();
            //t.a1 = 0;  not reachable // private
            t.a2 = 5;// public
            // t.a3 = 66; //not reachable protected
            // t.a4 = 5; not reachable// internal
            //t.a5 = 78; not reachable//protected internal


            TestDerivedClass td = new TestDerivedClass();
            //td.a1 = 0; not reacahable // private
            td.a2 = 6;//public
                      // td.a3 = 66; //not reachable protected
                      //td.a4 = 5; not reachable// internal
             //td.a5 = 78; not reachable//protected internal

            TestDerivedClassOtherAssembly tdo = new TestDerivedClassOtherAssembly();

            //tdo.a1 = 0; not reacahable // private
            tdo.a2 = 6;//public
            //tdo.a3 = 66; //not reachable protected
            //tdo.a4 = 5; not reachable// internal
           // tdo.a5 = 78; not reachable//protected internal
        }

        class TestDerivedClassOtherAssembly : TestClass
        {
            void M1()
            {
                // a1 = 1; not reachable //private
                a2 = 6; //public
                a3 = 7; //protected 
                        // a4 = 99; not reachable //internal
                a5 = 78; //protected internal
            }

        }
        


    }
}
