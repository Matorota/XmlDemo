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

            var pavarde = asmuoDocument.CreateElement("Pavarde");
            pavarde.InnerText = "P3";
            asmuo.AppendChild(pavarde);
            asmuo.SetAttribute("Amzius", "12");

            Console.WriteLine(asmuoDocument.OuterXml);
            Console.ReadLine();

        }
    }
}
