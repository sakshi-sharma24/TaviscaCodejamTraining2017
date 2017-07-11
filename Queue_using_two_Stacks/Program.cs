using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_using_two_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the queue");
            int size = Convert.ToInt32(Console.ReadLine());
            Queue_using_arrays q = new Queue_using_arrays(size);
            while (true)
            {
                Console.WriteLine("Enter 1)Enqueue\n2)Dequeue3)Display\n4)Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an element");
                        q.Enqueue(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        q.Dequeue();
                        break;
                    case 3:
                        q.Display();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}













        
