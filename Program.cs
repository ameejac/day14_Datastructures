using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();

	    //uc1 insert last
            //list.InsertLast(56);
            //list.InsertLast(30);
            //list.InsertLast(70);
            //list.Dispaly_list();

	    //uc2 Insertfront
	    /*
            list.Insertfront(70);
            list.Insertfront(30);
            list.Insertfront(56);
            list.Dispaly_list();
	    */

	    //uc3 Insertappending
            //list.Insertappend(30);
            //list.Insertappend(70);
            //list.Insertappend(56);
            //list.Dispaly_list();
      
            //uc4 Insert in between 30 to 56
            //list.Insertbetween(35,30);
            //Console.WriteLine("after inserting between\n");
            //list.Dispaly_list();

            //uc5 delete first node
            //Node deleted_node = list.Deletefirstnode();
            //Console.WriteLine("deleting firstnode number:" +deleted_node.data);
            //list.Dispaly_list();
	    //uc6 delete last node
            //list.Insertlist(70);
            //list.Insertlist(30);
            //list.Insertlist(56);
            //list.Dispaly_list();
            //Node deleted_node = list.Deletelastnode();
            //Console.WriteLine("deleting lastnode number:" +deleted_node.data); 
            
	     //uc7 searching for perticular node
            //list.Insertlist(70);
            //list.Insertlist(30);
            //list.Insertlist(56);
            //Node find = list.Search(20);
            //if (find != null)
            //{
            //Console.WriteLine("node found in main " + find.data);
            //}
            //list.Dispaly_list();

	    //uc1 create a stack
            //Stacks list = new Stacks();
            //list.push(70);
            //list.push(30);
            //list.push(56);
	    //list.Display();

	    //uc2 pop,peak
            //list.Display();
            //list.peak();
            //list.pop();
            //list.empty();
            //Console.WriteLine("peak value is:" + list.top.data);
	    
	     //uc1 create a queue
            queue list = new queue();
            list.insert(56);
            list.insert(30);
            list.insert(70);
            list.Display();


        }
    }
}    
