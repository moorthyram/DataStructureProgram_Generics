using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram_Generics
{
    public class CustomLinkedList
    {

            public Node head;
            public void AddLast(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} added into linked list", node.data);
            }
        public void AddFirst(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
            Console.WriteLine("{0} added into linked list", node.data);
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public Node Insert(int data, int value)
        {

            Node node = new Node(data);
            if (value == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                while (value != 0)
                {
                    if (value == 1)
                    {
                        node.next = head.next;
                        head.next = node;
                    }
                    //head = head.next;
                }
            }
            return head;
        }
        public void Display()
            {
                Console.WriteLine("\nDisplaying Nodes Data\n");
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Linked List is empty.");
                    return;
                }
                else
                {
                    while (temp != null)
                    {
                        Console.Write(" " + temp.data + " ");
                        temp = temp.next;
                    }
                }
                Console.WriteLine();
            }
        
    }
}
