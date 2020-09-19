using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameListXMLEditor
{
    public static class XmlServices
    {
        public static IEnumerable<XElement> ParseData(string data)
        {
            XDocument doc = XDocument.Parse(data);
            return doc.Root.Elements();
        }

        public static string GetNodeValueAsString(IEnumerable<XElement> nodeList, string key)
        {
            return nodeList.Where(n => n.Name.LocalName == key).FirstOrDefault()?.Value;
        }

        public static bool DoesNodeExist(IEnumerable<XElement> nodeList, string key)
        {
            var node = nodeList.Where(n => n.Name.LocalName == key).FirstOrDefault();
            if (node == null)
            {
                return false;
            }
            return true;
        }
    }
}
