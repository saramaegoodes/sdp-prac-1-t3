using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum_below = 0;                      
            for (int i = 0; i< 1000; i++)       //iterates until 1000
            {
                if ((i%3 ==0) || (i % 5 == 0))  //checks whether number is a multiple of 3 or 5
                {
                    sum_below += i;             //adds the multiples of 3 and 5 below 1000
                }
            }

            Console.WriteLine(sum_below);       //prints out result
            Console.Read();

        }
    }
}
