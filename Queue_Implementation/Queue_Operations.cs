using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
   public class Queue_Operations
    {
        private int[] queue_array;
        private int front = -1;
        private int rear = -1;
        int size_of_queue;

     public void Enqueue(int data_item)
        {
            if(rear==size_of_queue-1)
            {
                Console.WriteLine("OVERFLOW");
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                    Console.WriteLine("element to be inserted");
                    data_item = Convert.ToInt32(Console.ReadLine());
                    queue_array[++rear] = data_item;
                    Console.WriteLine("element inserted is {0}",queue_array[rear]);
                }    
            }
        }
      
        public void Dequeue()
        {
            if(front==-1||front>rear)
            {
                Console.WriteLine("Underflow");
            }
            else
            {
                
                Console.WriteLine("queue present element after dequeue {0}", queue_array[front]);
                front++;


            }

        }
        public void Display()
        {
            if(front==-1)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                for(int i=front;i<=rear;i++)
                {
                    Console.WriteLine(queue_array[i] + " ");

                }
            }



        }










        public Queue_Operations(int size )
        {
            queue_array = new int[size];
            size_of_queue = size;

        }


    }
}
