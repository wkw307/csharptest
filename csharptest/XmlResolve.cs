using System;
using System.Collections.Generic;
using System.Xml;
namespace csharptest
{
	public class XmlResolve
	{
        private string _xmlPath;
        List<Node> nodeList = new List<Node>();
        List<Edge> edgeList = new List<Edge>();
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
            doc.Load(xmlPath);
            XmlNodeList xmlNodeList = doc.SelectNodes("node");
            XmlNodeList xmlEdgeList = doc.SelectNodes("edge");

            Node node = new Node();
            Edge edge = new Edge();
            foreach (XmlNode xn1 in xmlNodeList)
            {
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
                XmlElement xe = (XmlElement)xn1;
                edge.Id = xe.GetAttribute("id");
                edge.Source = xe.GetAttribute("source");
                edge.Target = xe.GetAttribute("target");
                edgeList.Add(edge);
            }
        }
	}
}
