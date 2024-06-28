using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> bookStack = new Stack<string>();
            bookStack.Push("Book-1");
            bookStack.Push("Book-2");
            bookStack.Push("Book-3");
            bookStack.Push("Book-4");
            foreach (string book in bookStack)
            {
                Console.WriteLine(book);
            }
        }
    }
}
