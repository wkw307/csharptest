using System;
namespace csharptest
{
	public class Edge
	{
		public Edge()
		{
		}

		// edge id
		private string id;
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		// edge source
		private string source;
		public string Source
		{
			get { return source; }
			set { source = value; }
		}

		// edge target 
		private string target;
		public string Target
		{
			get { return target; }
			set { target = value; }
		}


	}
}
