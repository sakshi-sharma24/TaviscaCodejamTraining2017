using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
   public class Stack_Operations
    {
        private int[] stack;
        private int size;
        private int top_of_stack = -1;

        public bool push(int data_value)
        {
            if (top_of_stack == size - 1)
            {
                Console.WriteLine("stack is empty");
                return false;
            }
            else
            {
                stack[++top_of_stack] = data_value;
                Console.WriteLine("stack is {0}", stack[top_of_stack]);
                return true;
            }
        }

        public int pop()
        {
            if (top_of_stack == -1)
            {
                Console.WriteLine("stack is empty");
                return int.MaxValue;
            }
            else
            {
                int k = stack[top_of_stack--];
                return k;
            }
        }









        public Stack_Operations(int size_of_array)
        {
            stack = new int[size_of_array];
            size = size_of_array;
        }


    }
}











    