using System;
namespace csharptest
{
	public class Node
	{
		public Node()
		{
		}
		//tree id
		private string id;
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		//tree label
		private string label;
		public string Label
		{
			get { return label; }
			set { label = value; }
		}

		//tree community
		private string community;
		public string Community
		{
			get { return community; }
			set { community = value; }
		}

		//tree xposition
		private string xPosition;
		public string XPosition
		{
			get { return xPosition; }
			set { xPosition = value; }
		}

		// tree yposition
		private string yPosition;
		public string YPosition
		{
			get
			{
				return yPosition;
			}
			set { yPosition = value; }
		}

		// tree size
		private string size;
		public string Size
		{
			get { return size; }
			set { size = value; }
		}
	}
}
