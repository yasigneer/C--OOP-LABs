using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.name = "Person A";
            //p.nationality = "Turkey";


            //Student student = new Student();
            //student.name = "ahmet";
            //student.nationality = "iraq";

            //Person p1 = new Person();
            //p1.WhoAreYou();
            //Student s1 = new Student();
            //s1.WhoAreYou();
            //Teacher t1 = new Teacher();
            //t1.WhoAreYou();
            //Doctor d1 = new Doctor();
            //d1.WhoAreYou();


            Person[] personList = new Person[4];

            personList[0] = new Person("ahmet");
            personList[1] = new Student("mustafa");
            personList[2] = new Teacher("Ayşe");
            personList[3] = new Doctor("Salim");

            //for (int i = 0; i < personList.Length; i++)
            //{
            //   personList[i].WhoAreYou();
            //}



        }
    }

    class Person
    {
        public Person(string name)
        {
            Console.WriteLine("public Person() executed");
            this.name = name;

           // WhoAreYou();
        }

        private int x;

        public string name;
        public DateTime BirthDate { get; set; }
        public string nationality;   

        public virtual void WhoAreYou()
        {
            Console.WriteLine("I am a person");
        }
    }

          //derived: base class in C#
          //subclass: superclass in java
          //child: parent in data science
    class Student: Person
    {  
        public Student(string name):base(name)
        {
            this.name = name;
            Console.WriteLine("public Student() executed");
            
            //this.WhoAreYou();
            //base.WhoAreYou();
            // WhoAreYou();
        }
        public string studentId;


        
        public override void WhoAreYou() //hides base.WhoAreYou()
        {
            Console.WriteLine("I am a Student");
        }


    }

    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            this.name = name;
            Console.WriteLine("public Teacher() executed");
            // WhoAreYou();
        }


        public string employeeId;

        public override void WhoAreYou() //hides base.WhoAreYou()
        {
            Console.WriteLine("I am a Teacher");
        }
    }

    class Doctor : Person
    {
        public Doctor(string name) : base(name)
        {
            this.name = name;
            Console.WriteLine("public Doctor() executed");
            // WhoAreYou();
        }

        public string employeeId;

   
        public override void WhoAreYou() //hides base.WhoAreYou()
        {
            Console.WriteLine("I am a Doctor");
        }

    }

}
