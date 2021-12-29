using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            ////type  nameof/object/instance   = create operator     Object Template
            //Student student1 = new Student(1); // get instance, create object operations


            ////student1.id = 1;
            ////student1.fullName = "Çağatay Şencan";
            ////student1.birthDate = new DateTime(2004,12,30);

            ////student1.Id = 1;
            //student1.FullName = "Çağatay Şencan";
            //student1.BirthDate = new DateTime(2004, 12, 30);


            ////Console.WriteLine($"Id: {student1.Id}, Full Name: {student1.FullName}, Birth Date: {student1.BirthDate}");

            //student1.RegisterCourse("C#, Java Lang");

            //student1.StudyLesson();

            Student student1 = new Student();
            Student student2 = new Student(1);
            Student student3 = new Student(1, "Uygar Tunçdöken");

           // student3.Id = 1;

            Student student4 = new Student(1, "Çağatay Şencan", new DateTime(2004, 12, 30));

        }
    }

    class Student
    {
        //Class Members

        //constructor members / constructor methods

        #region 0. Constructor members

  public Student()
        {
            Console.WriteLine("Default , Student(), constructor executed....");
        }
        
        public Student(int id)
        {
            Id = id;
          
            Console.WriteLine("Overloaded , Student(int id), constructor executed....");
        }

        public Student(int id, String fullName)
        {
            Id = id;
            FullName = fullName;

            Console.WriteLine("Overloaded , Student(int id, String fullName), constructor executed....");
        }

        public Student(int id, String fullName, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;

            Console.WriteLine("Overloaded , Student(int id, String fullName, DateTime birthDate), constructor executed....");
        }

        #endregion
      

        //1. Field Members
        #region 1. Fields

        private int id;
        private String fullName;
        private DateTime birthDate;
        #endregion

        //2. property members
        #region 2. Properties
        #region Long Props

        // public int Id
        //{
        //    get
        //    {
        //        return id;

        //    }
        //    set
        //    {
        //        id = value;

        //    }
        //}
        //public String FullName
        //{
        //    get
        //    {
        //        return fullName;

        //    }
        //    set
        //    {
        //        fullName = value;

        //    }
        //}
        //public DateTime BirthDate
        //{
        //    get
        //    {
        //        return birthDate;

        //    }
        //    set
        //    {
        //        birthDate = value;

        //    }
        //}

        #endregion

        #region ShortProps

        public int Id { get; set; }
        public String FullName { get; set; }
        public DateTime BirthDate { get; set; }

        #endregion

        #region java like properties

        //public void setId(int id)
        //{
        //    this.id = id;
        //}

        //public int getId()
        //{
        //    return this.id;
        //}


        #endregion
        #endregion

        //3. Method Members
        
        #region 3. Method Members
        public  void StudyLesson()
        {
            Console.WriteLine($"Student: {FullName}  is Studying");
        }
        public void RegisterCourse(string courseName)
        {
            Console.WriteLine($"Student: {FullName}  registered the lesson: {courseName}");
        }

        #endregion


    }




}
