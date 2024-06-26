using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] subject= new string[3][];
            subject[0] = new string[3] { "maths", "science", "english"};
            subject[1] = new string[5] { "geography", "geometry", "algebra", "sanskrit", "marathi" };
            subject[2] = new string[2] { "hindi", "kannada"};

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Row Number is {i}");
                for (int j = 0; j < subject[i].Length; j++)
                {
                    Console.Write($"Col - {j} - {subject[i][j]}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
