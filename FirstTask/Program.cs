using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] Array = new int[] {1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            for(int i = 0; i<Array.Length; i++)
            {
                Console.Write(Array[i]);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            foreach(int item in Array)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
