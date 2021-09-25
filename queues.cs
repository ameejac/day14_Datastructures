using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{ 
    class queue
    {
        //uc1 insert appending the data
        public Node head;
        public Node tail;
        public void insert(int newdata)
        {
            Node newnode = new Node(newdata);
            if(head == null && tail == null)
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                tail.next = newnode;
                tail = newnode;
            }
            Console.WriteLine("inserting the elements:" +tail.data);
        }
	  public void Display()
        {
            Node temp = head;
            if(temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }

            while(temp != null)
            {
                Console.WriteLine("elements on the queue:" + temp.data);
                temp = temp.next;
            }
        }
