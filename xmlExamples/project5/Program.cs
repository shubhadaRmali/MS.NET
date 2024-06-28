using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\java files\\notice.dat";
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            /*using (FileStream FS = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                Notice notice = new Notice() { NoticeId = 2374, NoticeTitle = "We have lecture on Sunday!", NoticeDate = DateTime.Now };
                binaryFormatter.Serialize(FS,notice);
                FS.Close();
            }*/
            using (FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                Notice notice = binaryFormatter.Deserialize(FS) as Notice;
                FS.Close();
                Console.WriteLine($"Notice Id - {notice.NoticeId}\nNotice Title - {notice.NoticeTitle}\nNotice Date - {notice.NoticeDate}");
            }
        }
    }
}
