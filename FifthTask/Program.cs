using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;

            int[] Array = new int[] { 5, 1, 1, 1 };

            for (i = 0; i < Array.Length; i++)
            {
                for (j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] == Array[i])
                    {
                        Console.WriteLine(Array[j]);
                    }
                }
            }
        }
    }
}
