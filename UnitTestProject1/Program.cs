using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeodymiumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //O(n!)
            //n = 64
            // 64 * 63 * 62 * 61 ... = 

            //n^3

            int n = 10; //O(n^3)

            //for(int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        for (int k = 0; k < n; k++)
            //        {

            //        }
            //    }
            //}

            //Single Linked List
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            singleLinkedList.InsertAtEnd(3);
            singleLinkedList.InsertAtEnd(7);
            singleLinkedList.InsertAtEnd(10);
        }
    }
}
