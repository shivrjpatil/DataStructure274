using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Nodes
    {
        public int item;
        public Nodes left;
        public Nodes right;

        public Nodes(int data)
        {
            item = data;
            left = null;
            right = null;

        }
    }
    internal class BinarySearch
    {
        public Nodes root;
        public BinarySearch()
        {
            root = null;
        }

        public Nodes ReturnRoot()
        {
            return root;
        }

        public void Insert(int id)
        {
            Nodes newNode =new Nodes(id);
            if (root == null)
                root = newNode;
            else
            {
                Nodes current = root;
                Nodes parent;
                while(true)
                {
                    parent = current;
                    if(id<current.item)
                    {
                        current = current.left;
                        if(current==null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if(current==null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Display(Nodes Root)
        {
           if(Root != null)
            {
                Console.WriteLine(Root.item + " ");
                Display(Root.left);
                Display(Root.right);
            }
        }

        public void Post(Nodes Root)
        {
            if(Root != null)
            {
                Post(Root.left);
                Post(Root.right);
                Console.WriteLine(Root.item + " ");
            }
        }
        public void Inorder(Nodes Root)
        {
            if (Root != null)
            {
               Inorder(Root.left);
                Console.WriteLine(Root.item + " ");
                
                Inorder(Root.right);
            }
        }

    }
}
