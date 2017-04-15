using System;
using System.Collections.Generic;
using System.Xml;
namespace csharptest
{
	public class XmlResolve
	{
        private string _xmlPath;
        public List<Node> nodeList = new List<Node>();
        public List<Edge> edgeList = new List<Edge>();
        public XmlResolve()
		{
            this._xmlPath = string.Empty;
		}

		public XmlResolve(string _xmlPath)
        {
            this._xmlPath = _xmlPath;
        }

        public string xmlPath
        {
            get { return this._xmlPath; }
            set { this._xmlPath = value; }
        }

        public void XmlRead()
        {
            xmlPath = "test1.xml";
            XmlDocument doc = new XmlDocument();
            XmlElement root = null;

            doc.Load(xmlPath);
            root = doc.DocumentElement;
            XmlNodeList xmlNodeList = root.SelectNodes("//node");
            XmlNodeList xmlEdgeList = root.SelectNodes("//edge");

            
            
            foreach (XmlNode xn1 in xmlNodeList)
            {
                Node node = new Node();
                XmlElement xe = (XmlElement) xn1.ChildNodes[0].ChildNodes[0];
                node.community = xe.GetAttribute("value").ToString();
                xe = (XmlElement)xn1.ChildNodes[2];
                node.yPosition = xe.GetAttribute("y").ToString();
                node.xPosition = xe.GetAttribute("x").ToString();
                xe = (XmlElement)xn1;
                node.id = xe.GetAttribute("id").ToString();
                nodeList.Add(node);
            }
            foreach (XmlNode xn1 in xmlEdgeList)
            {
                Edge edge = new Edge();
                XmlElement xe = (XmlElement)xn1;
                edge.id = xe.GetAttribute("id");
                edge.source = xe.GetAttribute("source");
                edge.target = xe.GetAttribute("target");
                edgeList.Add(edge);
            }
        }
	}
}
