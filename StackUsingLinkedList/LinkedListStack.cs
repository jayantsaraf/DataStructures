using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsingLinkedList
{
    class LinkedListStack
    {
        public Node head;
        public void Push(int data)
        {
            Node node = new Node(data);
            Node temp = this.head;
            if(temp==null)
                head.next = node;
            else
            {
                node.next = temp;
                head.next = node;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while(temp.next!=null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (this.head == null)
                Console.WriteLine("Empty Stack");
            else
                Console.WriteLine(this.head.data);
        }
        public void Pop()
        {
            Node temp = this.head.next;
            this.head = temp;
            Console.WriteLine("Popped element: " + this.head.data);
        }
    }
}
