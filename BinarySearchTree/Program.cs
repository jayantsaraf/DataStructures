using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree Implementation");
            ImplementBST<int> bST = new ImplementBST<int>(56);
            bST.InsertData(30);
            bST.InsertData(70);
            bST.InsertData(22);
            bST.InsertData(40);
            bST.InsertData(60);
            bST.InsertData(95);
            bST.InsertData(11);
            bST.InsertData(65);
            bST.InsertData(3);
            bST.InsertData(16);
            bST.InsertData(63);
            bST.InsertData(67);
            bST.Display();
        }
    }
}
