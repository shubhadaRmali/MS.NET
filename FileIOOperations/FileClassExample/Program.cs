using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\DotNet-Jun-2024\Logger.txt";
            if (!File.Exists(path))
            {
                var fs = File.Create(path);
                fs.Close();
                fs.Dispose();
            }
            //File.WriteAllText(path, "Welcome To Infoway!");
            //File.WriteAllText(path, "Welcome To India!");
            File.AppendAllText(path, "Welcome To Maharashtra!");
        }
    }
}
