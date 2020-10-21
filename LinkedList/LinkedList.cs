using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
                this.head = node;
            else
            {
                Node temp = head;
                while(temp.next!=null)
                    temp = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} Data inserted in Linked List ", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
                Console.WriteLine("Linked List is empty");
            while(temp.next!=null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void AddAtFirst(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                head = node;
            else
            {
                node.next = head;
            }
            head = node;
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            Node temp = this.head;
            if (temp == null)
                temp = node;
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
        public void InsertAtSpecificPosition(int data, int pos)
        {
            Node node = new Node(data);
            Node temp = this.head;
            if(temp==null)
                Console.WriteLine("Linked List is empty");
            while(temp.next!=null)
            {
                if(temp.data==pos)
                {
                    node.next = temp.next;
                    temp.next = node;
                    break;
                }
                temp = temp.next;
            }
        }
    }
}
