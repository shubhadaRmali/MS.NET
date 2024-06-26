using System;


namespace _1DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5] { "shubhada", "bhumika", "komal", "shweta", "puja" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.ReadKey();
        }
    }
}
