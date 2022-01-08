using System;
using System.IO;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Type info = typeof(Student);

            //FieldInfo[] fieldInfos = info.GetFields();

            //foreach (var field in fieldInfos)
            //{
            //    Console.WriteLine(field.Name);
            //}

            //PropertyInfo[] propertyInfos = info.GetProperties();

            //foreach (var property in propertyInfos)
            //{
            //    Console.WriteLine(property.Name);
            //}

            //MethodInfo[] methodInfos = info.GetMethods();

            //foreach (var method in methodInfos)
            //{
            //    Console.Write(method.Name +":");


            //    foreach (var param in method.GetParameters())
            //    {
            //        Console.Write($"{param.Name} {param.ParameterType}," );
            //    }
            //    Console.Write("\n");
            //}

            //ConstructorInfo[] constructorInfos = info.GetConstructors();

            //foreach (var constructor in constructorInfos)
            //{
            //    Console.Write(constructor.Name + ":");

            //    foreach (var param in constructor.GetParameters())
            //    {
            //        Console.Write($"{param.Name} {param.ParameterType},");
            //    }

            //    Console.Write("\n");
            //}


            var student = Activator.CreateInstance<Student>();
            //var student2 = Activator.CreateInstance(info);

            var mi = info.GetMethod("M1");
            mi.Invoke(student,new object?[]{"Aydın",40});


            Type typeInfo = typeof(Console);

            foreach (var method in typeInfo.GetMethods())
            {
                Console.WriteLine(method);
            }

            var yaz = typeInfo.GetMethod("WriteLine", new Type[]{typeof(object)});
            yaz.Invoke(typeInfo, new object?[] {"Hello World"});
                

            Console.Read();
        }
    }

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
}
