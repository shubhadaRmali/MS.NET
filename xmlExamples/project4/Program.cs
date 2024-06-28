using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DisposePattern disposePattern = new DisposePattern();
            //disposePattern.Dispose();
            /*using (DisposePattern pattern = new DisposePattern())
            {

            }*/
            string path = "C:\\Users\\Group009\\Desktop\\MS.netAssignments\\log.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                //sw.WriteLine("Welcome to India");
                sw.Close();
            }
            using (StreamReader sr = new StreamReader(path))
            {
               // Console.WriteLine(sr.ReadToEnd());
               while (sr.Peek()!=-1)
                {
                   //Console.WriteLine(sr.Read());
                    Console.WriteLine(Convert.ToChar(sr.Read()));
                }
                sr.Close();
            }
            Console.ReadKey();
        
        }
    }
}
