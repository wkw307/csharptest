using System;

namespace csharptest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
            XmlResolve test = new XmlResolve();
            test.XmlRead();
		}
	}
}
