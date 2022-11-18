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
                    Console.WriteLine("\nCuplicate number not allowed:");
                    return;
                }
                newNode.next = STAR;
                if(STAR!=null)
                    STAR.prev = newNode;
                newNode.next = null;
                STAR = newNode;
                return;
            }
            //if the node is to be inserted at the end of the list
            Node previous, current;
            for (current = previous = STAR;
                current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nCuplicate number not allowed:");
                    return;
                }
            }
                //on the execution of the above for loop, prev, and curretnt
                //will point to those nodes between witch the new nodes is to
                //be inserted
                newNode.next = current;
                newNode.prev = previous;
            //if the nide is to be inserted at the end of the list

            if (current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return;
            }
            current.prev= newNode;
            previous.next = newNode;
            }

        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            previous = current = STAR;
            while(current!= null && rollNo != current.noMhs)
            { 
                previous=current;
                current= current.next;
            }
        }
        public bool dellNode(int rollNo)
        {
            Node previous , current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            return true;
            //the beginning of data 
            if (current.next = null)
            {
                previous.next = null;
                return true;
            }
            //Node between two nodes in the list
            if (current ==STAR)
            {
                STAR = STAR.next;
                if (STAR != null)
                    STAR.next = null;
                return true
            }
            public bool ListEmpty()
            {
                if (STAR = null)
                    return true;
                else
                    return false;
            }
            public void ascending()
            {
                if (ListEmpty())
                    Console.WriteLine("\nList is empty");
                else
                {
                    Console.WriteLine("\nRecord in the ascending oeder off" + "Roll number are:|n");
                    Node currentNode;
                    for (currentNode = STAR; currentNode != null; currentNode = currentNode.next)
                        Console.Write(currentNode.noMhs + currentNode.name + "\n");
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
