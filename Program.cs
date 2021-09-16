using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            list.Dispaly_list();
            // Console.WriteLine("inserted into list " + insertlist);
           // Console.WriteLine("inserted into list " +list.head.data);
        }
    }
}
