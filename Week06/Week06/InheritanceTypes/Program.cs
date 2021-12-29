using System;

namespace InheritanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            B b = new B();
            
        }
    }

    
    class A //base class of all
    {
        public int memberA { get; set; }
    }

    //single inheritance
    class B:A //derived class from A, parent class of C
    {
        public int memberB { get; set; }
    }

    class C : B //Multi level inheritance, derived class from B
    {
        public int memberC { get; set; }
    }

    class D:A //single inheritance
    {
        public int memberD { get; set; }
    }
    class E: A //single inheritance
    {
        public int memberE { get; set; }
    }

}
