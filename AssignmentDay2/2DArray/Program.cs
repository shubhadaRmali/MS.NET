using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] data = new string[2, 2] { { "shubhada", "mali" }, { "bhumika", "barhe" } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{data[i, j]}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
