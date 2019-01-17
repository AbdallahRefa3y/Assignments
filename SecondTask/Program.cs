using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {

        static void Main(string[] args)
        {
            int i, s;

            int[] Array = new int[] { 2, 5, 7 };

            for ( i = 0; i < 3; i++)
            {
                Console.WriteLine(Array[i]);
            }

          


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[] Array2 = new int[] { 2, 5, 7 };

            for ( s = Array2.Length - 1; s >= 0; s--)
            {
                Console.WriteLine(Array2[s]);
            }

        }
    }
}
