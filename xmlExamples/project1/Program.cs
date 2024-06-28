using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var htmlElement = new XElement("html", new XElement("head", new XElement("title")), new XElement("body",new XElement("div",new XAttribute("height",40),new XAttribute("width",50))));
            Console.WriteLine(htmlElement);
            Console.ReadKey();
        }
    }
}
