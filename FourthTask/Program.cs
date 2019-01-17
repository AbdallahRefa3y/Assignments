using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Program
    {

        //public int[]MainArray(int []Array)
        //{
        //    Array = new int[] { 15, 10, 12 };
        //    return Array;
        //}

        static void Main(string[] args)
        {
            int i,n = 0;

            int[] Array_1 = new int[] { 15, 10, 12 };

            for (i = 0; i < Array_1.Length; i++)
            {
                n = Array_1[i];

                Console.WriteLine("The elements stored in the first array are : " + Array_1[i]);
            }

            int[] Array_2 = new int[n];

            for (i = 0; i < Array_2.Length; i++)
            {
                Console.WriteLine("The elements stored in the first array are : " + Array_2[i]);

            }

            


            
            //int[][] jagged = new int[1][];

            //jagged[0] = new int[] { 15, 10, 12 };
            //jagged[1] = new int[jagged[0]];


        }
    }
}
