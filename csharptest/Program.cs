using System;

namespace csharptest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			XmlResolve test = new XmlResolve();
			test.XmlRead();
			PathGenerator pathGenerator = new PathGenerator();
			//Console.WriteLine(pathGenerator.CalPath(test.edgeList[0], test)[0].PositionX);
			Console.WriteLine(pathGenerator.CalPath(test.edgeList[2], test).Count);
			for (int i = 0; i < pathGenerator.CalPath(test.edgeList[2], test).Count; i++)
			{

				Console.Write("x: " + pathGenerator.CalPath(test.edgeList[2], test)[i].PositionX);
				Console.WriteLine(" y:" + pathGenerator.CalPath(test.edgeList[2], test)[i].PositionY);
			}
			//string s = "-3.14";
			//float ss = float.Parse(s);
			//Console.WriteLine(ss);
		}
	}
}
