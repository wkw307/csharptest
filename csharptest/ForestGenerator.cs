using System;
using System.Collections.Generic;

namespace csharptest
{
	public class ForestGenerator
	{
		public ForestGenerator()
		{
		}

		public void GenerateForest(XmlResolve xmlresolve)
		{
			PathGenerator pathGenerator = new PathGenerator();
			List<PathPRS> path = new List<PathPRS>();
			for (int i = 0; i < xmlresolve.edgeList.Count; i++)
			{
				path = pathGenerator.CalPath(xmlresolve.edgeList[i], xmlresolve);

			}
		}
	}
}
