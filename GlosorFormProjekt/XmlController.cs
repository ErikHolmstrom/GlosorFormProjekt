using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GlosorFormProjekt
{
    class XmlController
    {
        private const string xmlPath = @".\glosor.xml";

        public XmlController()
        {        
        }

        public String readFullXml()
        {
            //  XElement xmlTop = XElement.Load(xmlPath);
            /*  IEnumerable<string> partNos = from item in purchaseOrder.Descendants("Item")
                                            select (string)item.Attribute("PartNumber");*/
            XElement xml = XElement.Load(xmlPath);
            return xml.ToString();

            //throw new NotImplementedException();
        }

        public void WriteGlosaToXml(Glosa glosa)
        {
            XElement xml = XElement.Load(xmlPath);
            XElement parentElement = xml.Element("Glosor");

            parentElement.Add(glosa.XmlElement());

            WriteNewTextToFile(xml.ToString());

        }

        private void WriteNewTextToFile(String xml)
        {
            using (StreamWriter outputFile = new StreamWriter(xmlPath))
            {
                outputFile.Write(xml);
            }
        }
    }
}
