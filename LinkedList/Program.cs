using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedListImplement list = new LinkedListImplement();
            //UC1 Added Elements: -
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();

            //UC2 Adding the elements at first
            //list.AddAtFirst(56);
            //list.AddAtFirst(30);
            //list.AddAtFirst(70);
            //list.Display();

            ////UC3 Appending the data
            //list.Append(56);
            //list.Append(30);
            //list.Append(70);

            ////UC4 Insert 30 between 56 and 70
            list.Add(56);
            list.Add(70);
            list.Display();
            list.InsertAtSpecificPosition(30, 56);
            list.Display();
            ////UC5 Delete first element
            //list.DeleteFirst();
            //list.Display();

            ////UC6 Delete last element
            //list.DeleteLast();
            //list.Display();

            ////UC7 Search for 30
            list.SearchValue(30);

            ////UC8 Insert 40 after 30
            list.InsertAtSpecific(40, 30);




        }
    }
}
