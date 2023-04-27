using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Linked List\n2.Stack\n3.Queue\n4.Binary search tree");
            int option = Convert.ToInt32(Console.ReadLine());

          switch (option)
          {
                case 1:
                    LinkedList linkedList = new LinkedList();
                    linkedList.AddNode(34);
                    linkedList.AddNode(56);
                    linkedList.AddNode(67);
                    linkedList.dispaly();
                    break;
                case 2:
                    Stack stack = new Stack();
                    stack.Push(23);
                    stack.Push(24);
                    stack.Push(35);
                    stack.Display();
                    stack.Peek();
                    stack.Pop();
                    stack.Pop();
                    stack.Display();
                    break;
                case 3:
                    Queue queue = new Queue();
                    queue.Enqueue(23);
                    queue.Enqueue(78);
                    queue.Display();
                    queue.Dequeue();
                    queue.Display();
                    break;
                case 4:
                    BinarySearch binarySearch = new BinarySearch();
                    binarySearch.Insert(34);
                    binarySearch.Insert(23);
                    binarySearch.Insert(20);
                    binarySearch.Insert(25);

                    binarySearch.Display(binarySearch.ReturnRoot());
                    Console.WriteLine("\n");
                    binarySearch.Post(binarySearch.ReturnRoot());
                    Console.WriteLine("\n");
                    binarySearch.Inorder(binarySearch.ReturnRoot());
                    break;
          }
            Console.ReadLine();

        }
    }
}
