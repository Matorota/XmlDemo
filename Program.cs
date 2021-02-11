using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument asmuoDocument = new XmlDocument();
            XmlElement asmuo = asmuoDocument.CreateElement("asmuo");
            asmuoDocument.AppendChild(asmuo);
            
            var vardas = asmuoDocument.CreateElement("Vardas");
            vardas.InnerText = "Jonas";
            asmuo.AppendChild(vardas);




            Console.WriteLine(asmuoDocument.OuterXml);
            Console.ReadLine();

        }
    }
}
