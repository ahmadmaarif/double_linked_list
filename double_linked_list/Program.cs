using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
   
    }
        class Node 
        {
            /*Node class represent the node of doubly linked list
            * its consict of the information part and and list to
            * its seccuding and preceeding 
            * in terms of next and previous */
            public int noMhs;
            public string name;
            //point to the succeding node 
            public Node next;
            //point the preceending node
            public Node prev;
        class DoubleLinkedList
        {
            Node STAR;

            //constructor

            public void addNode()
            {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student:");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name of the student:");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;   
            newNode.name = nm;

            //check if the list empty
            if(STAR == null || nim<=STAR.noMhs)
            {
                if((STAR!=null) && (nim == STAR.noMhs))
                {

                }
            }
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
