using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class Node
    {
        public int data;
        public Node next;

       /*public void add (int data)
        {
            this.data = data;
            this.next = null;
        }*/
        public Node(int new_data)
        {
            this.data = new_data;
            this.next = null;
        } 
    }
}
