using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DisposePattern disposePattern=new DisposePattern();
            //disposePattern.Dispose();
            //using (DisposePattern pattern=new DisposePattern())
            //{

            //}
            string path = "C:\\DotNet-Jun-2024\\Messages.txt";
            using (StreamWriter SW=new StreamWriter(path,true))
            {
                //SW.WriteLine("Welcome To Mumbai!");
                SW.Close();
            }
            using (StreamReader SR=new StreamReader(path))
            {
                //Console.WriteLine(SR.ReadToEnd());
                while (SR.Peek()!=-1)
                {
                    //Console.WriteLine(SR.ReadLine());
                    Console.WriteLine(Convert.ToChar(SR.Read()));
                }
                SR.Close();
            }
        }
    }
}
