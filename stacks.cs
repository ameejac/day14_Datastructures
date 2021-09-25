using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class Stacks
    {
        //uc1 pushing the elements
        public Node top;
        public void push(int newdata)
        {
            Node newnode = new Node(newdata);
            if (this.top == null)
            {
                this.top = newnode;
            }
            else
            {
                newnode.next = this.top;
                this.top = newnode;
            }
            Console.WriteLine("push the data:"+newnode.data);
        }
	public void Display()
        {
            ///checking if stack is not empty
            ///printing values till temp point towards null i.e. end of stack
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("no values to display , empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in the stack : " + temp.data);
                temp = temp.next;
            }
        }
