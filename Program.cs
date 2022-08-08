

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
                  /*  linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);*/
                    linkedList.AddFirst(56);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(70);
                    linkedList.Display();
                    break;
            }
            Console.ReadLine();
        }
    }
}