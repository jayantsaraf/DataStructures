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
            bST.Display();
        }
    }
}
