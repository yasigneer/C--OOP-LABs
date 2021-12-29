using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FrameworkInterfaces.Annotations;

namespace FrameworkInterfaces
{
    class Program//:IEqualityComparer<Student>
    {
        static void Main(string[] args)
        {
            //MessageSender messageSender = new MessageSender();
            //messageSender.PropertyChanged += (sender, eventArgs) =>
            //{
            //    Console.WriteLine($"{eventArgs.PropertyName} - has changed");
            //    //get log
            //};

            //messageSender.IsMessageSent = true;
            //messageSender.IsMessageReceived = true;
            //messageSender.IsMessageSent = true;
            //messageSender.IsMessageReceived = true;


            //List<Student> students = new List<Student>();

            //students.Add(new Student()
            //{
            //    id = 3,
            //    firstName = "Ayşe",
            //    lastName = "Konuş"

            //});
            //students.Add(new Student()
            //{
            //    id = 2,
            //    firstName = "Barış",
            //    lastName = "Küçük"

            //});
            //students.Add(new Student()
            //{
            //    id = 4,
            //    firstName = "Berkay",
            //    lastName = "Ünlü"

            //});
            //students.Add(new Student()
            //{
            //    id = 1,
            //    firstName = "İrem",
            //    lastName = "Yaymak"

            //});

            //students.Sort();

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.id} - {student.firstName} {student.lastName}");
            //}

            //Student student1 = new Student()
            //{
            //    id = 2,
            //    firstName = "A"

            //};
            //Student student2 = new Student()
            //{
            //    id = 2,
            //    firstName = "A"
            //};

            // MyComparer myComparer = new MyComparer();
            // Console.WriteLine(myComparer.Compare(student1, student2));

            // Console.WriteLine(student1.Equals(student2));

            Program program = new Program();
            // Console.WriteLine(program.Equals(student1, student2));

            Student student = new Student();
            student.id = 2;
            student.firstName = "D";
            //Console.WriteLine(student.Current);
            //while (student.MoveNext())
            //{
            //    Console.WriteLine(student.Current);
            //}

            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}


            MyList myList = new MyList();
            myList.Add(student);
            myList.Add(new Student() {id = 12, firstName = "A"});
            myList.Add(new Student() { id = 13, firstName = "B"});

            foreach (var item in myList)
            {
                Console.WriteLine($"{item.id} {item.firstName}");
            }

        }

        //public bool Equals(object? x, object? y)
        //{
        //    return ((Student) x).id.GetHashCode() == ((Student) y).id.GetHashCode();
        //}

        //public bool Equals(Student x, Student y)
        //{
        //    return x.id.GetHashCode() == y.id.GetHashCode();
        //}

        //public int GetHashCode(object obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public int GetHashCode([DisallowNull] Student obj)
        //{
        //    throw new NotImplementedException();
        //}


    }

    class MyList:ICollection<Student>
    {
        private List<Student> students = new List<Student>();

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in students)
            {
                yield return student;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Student item)
        {
            students.Add(item);
        }

        public void Clear()
        {
            students.Clear();
        }

        public bool Contains(Student item)
        {
           return students.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Student item)
        {
           return students.Remove(item);
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }

    class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }


    //class Student : ICollection
    //{
    //    private List<double> grades = new List<double>() { 50, 50, 70, 80 };
    //    public int id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }

    //    public IEnumerator GetEnumerator()
    //    {
    //        foreach (var grade in grades)
    //        {
    //            yield return grade;
    //        }
    //    }


    //    public IEnumerator GetEnumerator()
    //    {
    //        foreach (var grade in grades)
    //        {
    //            yield return grade;
    //        }
    //    }

    //    public void CopyTo(Array array, int index)
    //    {

    //    }

    //    public int Count { get; }
    //    public bool IsSynchronized { get; }
    //    public object SyncRoot { get; }
    //}

    //class Student:IEnumerable<double>
    //{
    //    private List<double> grades = new List<double>() { 50, 50, 70, 80 };
    //    public int id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }

    //    //public IEnumerator GetEnumerator()
    //    //{
    //    //    foreach (var grade in grades)
    //    //    {
    //    //        yield return grade;
    //    //    }
    //    //}


    //    public IEnumerator<double> GetEnumerator()
    //    {
    //        foreach (var grade in grades)
    //        {
    //            yield return grade;
    //        }
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}

    //class Student : IEnumerator<double>
    //{
    //    private List<double> grades = new List<double>() { 50, 50, 70, 80 };
    //    public int id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }

    //    private int index = 0;
    //    public bool MoveNext()
    //    {
    //        if (grades.Count == 0 || grades.Count <= index + 1)
    //        {
    //            return false;
    //        }

    //        index++;
    //        return true;
    //    }

    //    public void Reset()
    //    {
    //        index = 0;
    //    }

    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }



    //    double IEnumerator<double>.Current => grades[index];

    //    public object Current => grades[index];
    //}

    //class Student : IEquatable<Student>
    //{
    //    public int id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }

    //    public bool Equals(Student other)
    //    {
    //        return this.id == other.id;
    //    }
    //    //public int CompareTo(object? obj)
    //    //{
    //    //    var other = (Student)obj;
    //    //    return this.id.GetHashCode().CompareTo(other.id.GetHashCode());
    //    //}

    //    //public int CompareTo(Student? other)
    //    //{
    //    //    return this.id.GetHashCode().CompareTo(other.id.GetHashCode());
    //    //}
    //}

    class MyComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.id.GetHashCode().CompareTo(y.id.GetHashCode());
        }
    }



    //class Student:IComparable
    //{
    //    public int id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public int CompareTo(object? obj)
    //    {
    //        var other = (Student) obj;
    //        return this.id.GetHashCode().CompareTo(other.id.GetHashCode());
    //    }
    //}

    //class Student : IComparable<Student>
    //{
    //    public int id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    //public int CompareTo(object? obj)
    //    //{
    //    //    var other = (Student)obj;
    //    //    return this.id.GetHashCode().CompareTo(other.id.GetHashCode());
    //    //}

    //    public int CompareTo(Student? other)
    //    {
    //        return this.id.GetHashCode().CompareTo(other.id.GetHashCode());
    //    }
    //}

    class MessageSender : INotifyPropertyChanged
    {
        private bool isMessageSent;

        public bool IsMessageSent
        {
            get { return isMessageSent; }
            set
            {
                isMessageSent = value;
                OnPropertyChanged("IsMessageSent");
            }
        }

        private bool isMessageReceived;

        public bool IsMessageReceived
        {
            get { return isMessageReceived; }
            set
            {
                isMessageReceived = value;
                OnPropertyChanged("IsMessageReceived");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
