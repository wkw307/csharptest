using System;
namespace csharptest
{
	public class PathPRS
	{
		public PathPRS()
		{
			this.PositionZ = 0;
			this.RotationX = 0;
			this.RotationY = 0;
			this.RotationZ = 0;
			this.ScaleX = 1;
			this.ScaleY = 1;
			this.ScaleZ = 1;
		}
		public float PositionX { get; set; }
		public float PositionY { get; set; }
		public float PositionZ { get; set; }
		public float RotationX { get; set; }
		public float RotationY { get; set; }
		public float RotationZ { get; set; }
		public float ScaleX { get; set; }
		public float ScaleY { get; set; }
		public float ScaleZ { get; set; }
	}
}
