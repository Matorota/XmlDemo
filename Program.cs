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
            var asmenys = asmuoDocument.CreateElement("Asmenys");
            asmuoDocument.AppendChild(asmenys);

            for (int i = 0; i < 10; i++)
            {
                var r = new Random();
            XmlElement asmuo = asmuoDocument.CreateElement("Asmuo");
            //asmuoDocument.AppendChild(asmuo);
            
            var vardas = asmuoDocument.CreateElement("Vardas");
            vardas.InnerText = "Jonas" + r.Next(1, 10);
            asmuo.AppendChild(vardas);

            var pavarde = asmuoDocument.CreateElement("Pavarde");
            pavarde.InnerText = "P3" + r.Next(1, 10);
            asmuo.AppendChild(pavarde);

            asmuo.SetAttribute("Amzius", $"{r.Next(1, 10)}");

                asmenys.AppendChild(asmuo);
            }
            Console.WriteLine(asmuoDocument.OuterXml);

  Console.ReadKey();
            /*var asmuoReadDocument = new XmlDocument();
            asmuoReadDocument.LoadXml(asmuoDocument.OuterXml);

            var vardasRead = asmuoReadDocument.SelectSingleNode("/Asmuo/Vardas").InnerText;
            var amziusRead = asmuoReadDocument.SelectSingleNode("/Asmuo").Attributes["Amzius"].InnerText;
            
            Console.WriteLine(vardasRead);
            Console.WriteLine(amziusRead);
*/
          

        }
    }
}
