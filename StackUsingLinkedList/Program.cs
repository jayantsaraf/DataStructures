using System;

namespace StackUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedListStack list = new LinkedListStack();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
        }
    }
}
