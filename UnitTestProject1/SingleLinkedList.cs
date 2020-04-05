using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeodymiumDemo
{
    public class SingleLinkedList
    {
        //starting node
      
        Node start = null;

        public void InsertAtEnd(int info) //10
        {
            //create the node
            Node node = new Node(); //10
            node.data = info;

            if(start == null) //start = 3
            {
                start = node;
                return;
            }

            Node temp = start; //7
            while (temp.link != null)
            {
                temp = temp.link;
            }
            temp.link = node;
        }
    }
}
