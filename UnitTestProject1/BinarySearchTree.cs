using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class BinarySearchTree
    {
        public Node root = null;

        public void Add(int data) //20, 25, 30
        {
            Node node = new Node(); //20, 25, 30
            node.data = data;

            if (root == null)
            {
                root = node;
                return;
            }
            Node temp = root;

            while (temp.link != null)
            {
                if(data >= temp.data)
                {
                    if (temp.RightChild != null)
                    {
                        temp = temp.RightChild;
                    }
                    else if (data < temp.data)
                    {
                        if(temp.LeftChild != null)
                        {
                            temp = temp.LeftChild;
                        }
                        else
                        {
                            temp.LeftChild = node;
                        }

                    }
                }
                
            }
        }
        public bool SearchTree(Node root, int data)
        {
            if (root == null)
            {
                return false;
            }
            else if (data < root.data)
            {
                return SearchTree(root.LeftChild, data);
            }
            else if (data > root.data)
            {
                return SearchTree(root.RightChild, data);
            }
            if (data == root.data)
            {
                return true;
            }
            else
            {
                return false;
            }
        }  
    }
}
