﻿

namespace DataStructureProgram_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Problems Using c# Generics\n");
            Console.WriteLine("Please choose below number\n1:This is Linked List.");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    CustomLinkedList linkedList = new CustomLinkedList();
                    linkedList.Add(56);
                    linkedList.Add(30);
                    linkedList.Add(70);
                    linkedList.Display();
                    break;
            }
            Console.ReadLine();
        }
    }
}