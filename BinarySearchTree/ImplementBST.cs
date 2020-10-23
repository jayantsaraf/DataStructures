using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class ImplementBST<T> where T:IComparable
    {
        public T nodeData { get; set; }
        public ImplementBST<T> leftTree { get; set; }
        public ImplementBST<T> rightTree { get; set; }
        public ImplementBST(T data)
        {
            this.nodeData = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        public void InsertData(T data)
        {
            T currentNodeValue = this.nodeData;
            if(currentNodeValue.CompareTo(data)>0)
            {
                if (this.leftTree == null)
                    this.leftTree = new ImplementBST<T>(data);
                else
                    this.leftTree.InsertData(data);       
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new ImplementBST<T>(data);
                else
                    this.leftTree.InsertData(data);
            }
            
        }
        public void Display()
        {
            if (this.leftTree != null)
                this.leftTree.Display();
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
                this.rightTree.Display();
        }
        public bool Search(T element, ImplementBST<T> node)
        {
            if (node == null)
                return false;
            if (node.nodeData.Equals(nodeData))
            {
                Console.WriteLine("Element present in BST" + node.nodeData);
                return true;
            }
            else
                Console.WriteLine("Current element: " + node.nodeData);
            if (element.CompareTo(node.nodeData) < 0)
                Search(element, node.leftTree);
            else
                Search(element, node.rightTree);
            return false;
        }
        
    }
}
