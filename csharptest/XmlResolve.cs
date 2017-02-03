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
                node.Community = xe.GetAttribute("value").ToString();
                xe = (XmlElement)xn1.ChildNodes[2];
                node.YPosition = xe.GetAttribute("y").ToString();
                node.XPosition = xe.GetAttribute("x").ToString();
                xe = (XmlElement)xn1;
                node.Id = xe.GetAttribute("id").ToString();
                nodeList.Add(node);
            }
            foreach (XmlNode xn1 in xmlEdgeList)
            {
                Edge edge = new Edge();
                XmlElement xe = (XmlElement)xn1;
                edge.Id = xe.GetAttribute("id");
                edge.Source = xe.GetAttribute("source");
                edge.Target = xe.GetAttribute("target");
                edgeList.Add(edge);
            }
        }
	}
}
