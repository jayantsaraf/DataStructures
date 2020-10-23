using HashTableDemo;
using Microsoft.VisualBasic;
using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "Be");
            hash.Add("2", "Or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "Be");
            string hash5 = hash.Get("5");
            Console.WriteLine("Element present at 5th index:{0}",hash5);

        }
    }
}
