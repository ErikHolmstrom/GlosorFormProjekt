using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GlosorFormProjekt
{
    class Glosa
    {
        private String text;
        private String translation;

        public Glosa()
        {
        }

        public Glosa(String text, String translation)
        {
            this.text = text;
            this.translation = translation;
        }

        public String Text
        {
            get { return this.text; }
            set{ this.text = value; }
        }

        public String Translation
        {
            get { return this.translation; }
            set { this.translation = value; }
        }

        public bool isCorrect(String testText)
        {
            if(this.text.Equals(testText))
            {
                return true;
            }
            return false;
        }

        public XElement XmlElement()
        {
            XElement xmlElement = new XElement("Glosa");

            XElement textElement = new XElement("Text");
            textElement.SetValue(Text);
            xmlElement.Add(textElement);

            XElement translationElement = new XElement("Translation");
            translationElement.SetValue(Translation);
            xmlElement.Add(translationElement);

            return xmlElement;
            
        }

    }
}
