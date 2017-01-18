using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("Multiples of " + i);
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(j * i + " ");
                    Console.Write("\t");
                }

                Console.WriteLine("");
            }
        }
    }
}
