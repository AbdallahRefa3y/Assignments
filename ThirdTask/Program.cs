using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{

    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum;
            sum = 0;
            int[] Array = new int[] { 2, 5, 8};


            for (i = 0; i <Array.Length; i++)
            {
                n = Array[i];
                sum = sum + n;

                //if (n < sum)
                //{
                //    Console.WriteLine("sum of all elements in Array :" + sum);

                //}

                //Console.WriteLine("sum of all elements in Array :" + sum);
            }

            Console.WriteLine("Sum of all elements stored in the array is : " + sum);

        }
    }
}
