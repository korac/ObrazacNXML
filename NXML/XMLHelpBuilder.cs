using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NXML
{
    class XMLHelpBuilder
    {
        public enum DateTimeFormat { DateTime, DateOnly };

        private readonly XmlDocument doc;

        public XMLHelpBuilder(XmlDocument doc)
        {
            this.doc = doc;
        }

        public void CreateXmlDeclaration()
        {
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));
        }

        public XmlNode CreateRoot(string rootName)
        {
            return doc.AppendChild(doc.CreateElement(rootName));
        }
        public XmlNode CreateRoot(XmlNode rootName)
        {
            return doc.AppendChild(rootName);
        }

        public XmlNode AppendChild(XmlNode node, string childName)
        {
            return node.AppendChild(doc.CreateElement(childName));
        }
        public XmlNode AppendChild(XmlNode node, XmlNode childNode)
        {
            return node.AppendChild(childNode);
        }

        public XmlNode AppendChild(XmlNode node, string childName, string innerText)
        {
            XmlNode child = node.AppendChild(doc.CreateElement(childName));
            child.InnerText = innerText;
            return child;
        }

        public XmlNode AppendChild(XmlNode node, string childName, DateTime innerText, DateTimeFormat format)
        {
            if (format == DateTimeFormat.DateOnly)
                return AppendChild(node, childName, innerText.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo));
            else
                return AppendChild(node, childName, innerText.ToString("yyyy-MM-ddTHH:mm:ss", DateTimeFormatInfo.InvariantInfo));
        }

        public XmlNode AppendChild(XmlNode node, string childName, int innerText)
        {
            return AppendChild(node, childName, innerText.ToString("0", NumberFormatInfo.InvariantInfo));
        }

        public XmlNode AppendChild(XmlNode node, string childName, double innerText)
        {
            return AppendChild(node, childName, Math.Round(innerText, 2, MidpointRounding.AwayFromZero).ToString("0.00", NumberFormatInfo.InvariantInfo));
        }

        public XmlNode SetAttribute(XmlNode node, string attrName, string attrValue)
        {
            ((XmlElement)node).SetAttribute(attrName, attrValue);
            return node;
        }
    }
}
