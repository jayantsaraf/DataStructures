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
    }
}
