using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_using_two_Stacks
{

        public class Queue_using_arrays
        {

            private Stack stack_inside, stack_outside;
            private int size_of_queue;



            public bool Enqueue(int data)
            {
                if (stack_inside.push(data))
                {
                    return true;
                }
                else return false;
            }

            public void Dequeue()
            {
                int i = stack_inside.pop(), temp;
                while (i != int.MaxValue)
                {
                    stack_outside.push(i);
                    i = stack_inside.pop();
                }
                temp = stack_outside.pop();
                i = stack_outside.pop();
                while (i != int.MaxValue)
                {
                    stack_inside.push(i);
                    i = stack_outside.pop();
                }

            }

            public void Display()
            {
                stack_inside.display();
            }

            public Queue_using_arrays(int SizeOfQueue)
            {
                stack_inside = new Stack(SizeOfQueue);
                stack_outside = new Stack(SizeOfQueue);
                size_of_queue = SizeOfQueue;
            }
        }
    }






