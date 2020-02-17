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

            int[] arr = new int[1000000];
            int num = 2;
            arr[num - 2] = 1;
            arr[num - 1] = 2;
            int num2 = arr[num];

            int sum = 0;
            for (int i = 2; arr[i - 1] < 4000000; i++)
            {
                arr[i] = arr[(i - 1)] + arr[(i - 2)];
            }
            for (int j = 0; j <= arr.Length - 1; j++)
            {
                if (arr[j] % 2 == 0)
                    sum += arr[j];
            }
            Console.Write(sum);
            Console.Read();
        }
    }
}
