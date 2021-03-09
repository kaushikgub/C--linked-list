using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            Console.WriteLine(linkedList.print());
        }
    }
}
