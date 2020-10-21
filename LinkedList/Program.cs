using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            //UC1 Added Elements: -
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();
            //UC2 Adding the elements at first
            list.AddAtFirst(56);
            list.AddAtFirst(30);
            list.AddAtFirst(70);
            list.Display();


        }
    }
}
