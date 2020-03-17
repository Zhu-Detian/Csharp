using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{


    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
    }
    public void Foreach(Action<T> action)
    {
        Node<T> h = head;
        while (h != null)
        {
            action(h.Data);
            h = h.Next;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            list.Foreach(x => Console.WriteLine(x));
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int sum = 0;
            intlist.Foreach(s => { max = max < s ? s : max; });
            intlist.Foreach(s => { min = min > s ? s : min; });
            intlist.Foreach(s => { sum += s; });
            Console.WriteLine($"Max:{max}");
            Console.WriteLine($"Min:{min}");
            Console.WriteLine($"Sum:{sum}");
        }

    }
}