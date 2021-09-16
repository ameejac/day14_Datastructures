using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class Linkedlist
    {
        public Node head;
        /// </summary>
        /// uc 1 insert elements at last
        ///<param name ="new_data"></param>
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list " + new_node.data);
        }
	
	/* add the element on front */
        public void Insertfront(int new_data)
        {
            Node new_node = new Node(new_data); //it will create object and initialize the data
            if (this.head == null)
            {
                this.head = new_node;    
            }
            else
            {
                new_node.next = this.head;   // new_node->next will have head
                this.head = new_node;        // head now having the new_node
            }
            Console.WriteLine("inserted into list " + new_node.data);
        }

       
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        // add the element on appending

        public void Insertappend(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node AppendNode = GetLastNode(); 
                AppendNode.next = new_node;
                
            }
            Console.WriteLine("Appnded to list  " + new_node.data);
        }
	//uc4 insert in between 30 to 56
        public void Insertbetween(int new_data, int data)
        {
            //int data = 30;
            Node new_node = new Node(new_data);

            if (head.data == data)
            {
                new_node.next = head.next;
                head.next = new_node;
            }
            else
            {
                Node temp;
                temp = head;
                while(temp.next != null)
                {
                    if(temp.data == data)
                    {
                        new_node.next = temp.next;
                        temp.next = new_node;
                        break;
                    }
                    temp = temp.next;
                }

            }

        }
        public void Dispaly_list()
        {
            if (this.head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node temp = this.head;
                while (temp != null)
                {
                    Console.WriteLine("node is: " + temp.data);
                    temp = temp.next;
                }

            }
        }
    }
}
