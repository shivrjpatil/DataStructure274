using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if(head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;

                while(temp.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linkedlist",node.data);
        }

        public void AddReverseData(int data)
        {
            Node newNode=new Node(data);
            if(this.head==null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.Next = temp;
            }

        }

        public void PopLast()
        {
            Node tempnode = head;
            Node lastnode=tempnode.Next;
            if(head.Next!=null)
            {
                tempnode = tempnode.Next;
                tempnode.Next = null;
                lastnode = null;
            }
        }
        public void dispaly()
        {
            if(head==null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node tempnode = head;

                while(tempnode!=null)
                {
                    Console.WriteLine(tempnode.data);
                    tempnode = tempnode.Next;
                }
            }
        }
    }
}
