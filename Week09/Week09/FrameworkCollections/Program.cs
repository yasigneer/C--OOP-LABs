using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace FrameworkCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            List<int> list = new List<int>();//type safety

            arrayList.Add(new Student());
            arrayList.Add(1);
            arrayList.Add("Aydın");
            //arrayList.Sort();

            SortedList sortedList = new SortedList();
            //  SortedList<Student> sortedListGeneric;
            ///SortedList<int> list2 = new SortedList<int>();

            sortedList.Add(1, "Aydın");
            sortedList.Add(2, "Ahmet");
            sortedList[2] = "Ahmet";

            foreach (var item in sortedList.Values)
            {
                Console.WriteLine(item);
            }

            Hashtable hashtable = new Hashtable();
            HashSet<Student> hashSet = new HashSet<Student>();

            hashSet.Add(new Student());


            hashtable.Add(1, "Aydın");
            hashtable.Add(2, "Ahmet");
            hashtable[1] = "Mustafa";
            foreach (var item in hashtable.Values)
            {
                Console.WriteLine(item);
            }


            Queue queue = new Queue();
            Queue<int> queueGeneric = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue("Aydın");
            queue.Dequeue();

            Stack stack = new Stack();
            Stack<int> stackGeneric = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push("Aydın");
            stack.Pop();


            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary[1] = "Ahmet";
            dictionary[2] = "Ayşe";

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }


            LinkedList<Student> linkedList = new LinkedList<Student>();
            linkedList.AddFirst(new Student());
            //linkedList.AddAfter();


            MyList<Student> myList = new MyList<Student>();

            myList.Add(new Student() {id = 1});
            myList.Add(new Student() { id = 2});

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item.id);
            }

            MyMethod<Student,int,string>(new Student(), 2,"Aydın");
        }

        static T MyMethod<T,K, L>(T t,K k,L l)
        {

            return t;
        }
    }

    class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }


    class MyList<T> where  T:  class, new ()
    {
        private List<T> list;
        public MyList()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public List<T> Items  => list;
    }
}
