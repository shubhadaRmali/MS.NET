using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Group009\\Desktop\\MS.netAssignments\\file.txt";
            string path2 = "C:\\Users\\Group009\\Desktop\\MS.netAssignments\\NEWfile.txt";
            if (File.Exists(path))
            {
                var fs=File.Create(path);
                fs.Close();
            }
            File.WriteAllText(path, "Welcome to Mercedes!...");
            File.AppendAllText(path, "Welcome to India");
            Console.WriteLine("file is created");

            /*delete file
               File.Delete(path2);
               Console.WriteLine("The file has been deleted");
            */

            /*
            FileInfo file1 = new FileInfo(path);
            FileInfo file2 = new FileInfo(path2);
            file1.CopyTo(path2);
            Console.WriteLine("Copied Successfully", path, path2);
            */

            /*string path3 = "C:\\Users\\Group009\\Desktop\\MS.netAssignments\\NEWfile.txt";
            string path4 = "C:\\Users\\Group009\\Desktop\\MS .NET";
            FileInfo f3 = new FileInfo(path3);
            FileInfo f4 = new FileInfo(path4);
            f3.MoveTo(path4);
            Console.WriteLine("Moved Successfully", path3, path4);
           */



            /* Opentext Method  
            FileInfo fio = new FileInfo("C:\\Users\\Group009\\Desktop\\MS.netAssignments\\NEWfile.txt");
            StreamReader sr = fio.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            */

            Console.ReadKey();
        }
    }
}
