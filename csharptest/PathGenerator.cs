using System;
using System.Collections.Generic;

namespace csharptest
{
	///<summary>
	///知识森林中两主题间路径生成
	///</summary>
	public class PathGenerator
	{
		/// <summary>
		/// 存放两个主题间放路径方块的坐标
		/// </summary>
		public List<PathPRS> pathList = new List<PathPRS>();

		/// <summary>
		/// Initializes a new instance of the <see cref="T:csharptest.PathGenerator"/> class.
		/// </summary>
		public PathGenerator()
		{

		}

		/// <summary>
		/// Cals the path.
		/// </summary>
		/// <returns>The path.</returns>
		/// <param name="edge">Edge.</param>
		/// <param name="xmlResolve">Xml resolve.</param>
		public List<PathPRS> calPath(Edge edge, XmlResolve xmlResolve)
		{
			float sx = 0, sy = 0, tx = 0, ty = 0;
			int tag = 0;
			for (int i = 0; i < xmlResolve.nodeList.Count; i++)
			{
				if (edge.source.Equals(xmlResolve.nodeList[i].id))
				{
					tag++;
					sx = float.Parse(xmlResolve.nodeList[i].xPosition);
					sy = float.Parse(xmlResolve.nodeList[i].yPosition);
				}
				if (edge.target.Equals(xmlResolve.nodeList[i].id))
				{
					tag++;
					tx = float.Parse(xmlResolve.nodeList[i].xPosition);
					ty = float.Parse(xmlResolve.nodeList[i].yPosition);
				}
				if (tag == 2)
				{
					break;
				}
			}

			if (sx > tx)
			{
				return calLine(sx, sy, tx, ty, 1);
			}
			else
			{
				return calLine(tx, ty, sx, sy, 1);
			}
		}

		/// <summary>
		/// 从左到右计算线段上点的坐标(默认起始点在左)
		/// </summary>
		/// <returns>The line.</returns>
		/// <param name="sx">起始的横坐标</param>
		/// <param name="sy">起始的纵坐标</param>
		/// <param name="tx">目标的横坐标</param>
		/// <param name="ty">目标的纵坐标</param>
		/// <param name="delta">每两个点之间的横坐标或纵坐标的间隔</param>
		public List<PathPRS> calLine(float sx, float sy, float tx, float ty, float delta)
		{
			List<PathPRS> line = new List<PathPRS>();
			float cx = sx, cy = sy;
			if (Math.Abs(sx - tx) > Math.Abs(sy - ty))
			{
				float k = (ty - sy) / (tx - sx);

				while (cx < tx)
				{
					PathPRS cPRS = new PathPRS();
					cPRS.PositionX = cx;
					cPRS.PositionY = cy;
					line.Add(cPRS);
					cx = cx + delta;
					cy = k * delta + cy;
				}
			}
			else if (Math.Abs(sx - tx) < 0.0001)
			{
				if (sy > ty)
				{
					while (cy > ty)
					{
						PathPRS cPRS = new PathPRS();
						cPRS.PositionX = cx;
						cPRS.PositionY = cy;
						line.Add(cPRS);
						cy += delta;
					}
				}
				else
				{
					while (cy < ty)
					{
						PathPRS cPRS = new PathPRS();
						cPRS.PositionX = cx;
						cPRS.PositionY = cy;
						line.Add(cPRS);
						cy -= delta;
					}
				}
			}
			else
			{

				float m = (sx - tx) / (sy - ty);
				while (Math.Abs(cy - ty) < delta)
				{
					PathPRS cPRS = new PathPRS();
					cPRS.PositionX = cx;
					cPRS.PositionY = cy;
					line.Add(cPRS);
					cy += delta;
					cx = m * delta + cy;
				}

			}
			PathPRS tPRS = new PathPRS();
			tPRS.PositionX = tx;
			tPRS.PositionY = ty;
			return line;
		}
	}
}
