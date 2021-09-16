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
            list.Insertappend(30);
            list.Insertappend(70);
            list.Insertappend(56);
            list.Dispaly_list();

        }
    }
}
