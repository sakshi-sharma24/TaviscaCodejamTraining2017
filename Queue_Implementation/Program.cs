using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
   public class Queue
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("enter the size of queue");
            int size_of_Queue = Convert.ToInt32(Console.ReadLine());
            Queue_Operations q = new Queue_Operations(size_of_Queue);
            while (true)
            {
            int choice;
            Console.WriteLine("enter your choice 1) ENQUEUE/n 2)DEQUEUE/n 3)DISPLAY/n 4)EXIT");
            choice = Convert.ToInt32(Console.ReadLine());
            
             switch(choice)
                {

                    case 1:
                        Console.WriteLine("enter the element to be inserted");
                        int number_to_be_inserted = Convert.ToInt32(Console.ReadLine());
                        q.Enqueue(number_to_be_inserted);
                        break;
                    case 2: q.Dequeue();
                        break;
                    case 3:q.Display();
                        break;
                    case 4:Environment.Exit(100);
                        break;
                    default: Console.WriteLine("entered invalid choice");
                        break;










                }










            }
        }
    }
}
