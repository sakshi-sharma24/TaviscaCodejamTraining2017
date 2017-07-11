using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Zeros_in_Factorial
    {
       public class Factorial
        {
           public  static void Main(string[] args)
            {
                Console.WriteLine("enter number :");
                int n = int.Parse(Console.ReadLine());
                long factorial = 1; int number_of_zero = 0;

                for (int i = 1; i <= n; i++)
                {
                    factorial = factorial * i;
                }


                Console.WriteLine(factorial);

                while (factorial % 10 == 0)
                {
                number_of_zero++;
                    factorial /= 10;
                }
                Console.WriteLine(number_of_zero);
                Console.ReadLine();





            }

        }
    }





