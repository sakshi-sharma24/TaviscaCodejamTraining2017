using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int size_of_datastructure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the data element to be inserted");
            int data_item = Convert.ToInt32(Console.ReadLine());
            Stack_Operations stackobject = new Stack_Operations(size_of_datastructure);
            int choice;
            bool op = true;
            while (op)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1) PUSH/n 2)POP/n 3) Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        stackobject.push(data_item);
                        break;
                    case 2:
                        stackobject.pop();
                        break;
                    case 3:
                        op = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }
            }






        }
    }
}
