using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("   \t");
            for (int i = 1; i <= 9; i++)
                Console.Write(i + " \t");
            Console.WriteLine();
            Console.Write("   ");
            for (int i = 1; i <= 9; i++)
                Console.Write("________");
            Console.Write("\n\n");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i + " |\t");
                for (int j = 1; j <= 9; j++)
                    if (i * j < 10)
                        Console.Write(i * j + " \t");
                    else
                        Console.Write(i * j + "\t");
                Console.WriteLine();
            }
        }
    }
}
