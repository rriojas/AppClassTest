using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClassTest
{
  internal class Point2D: Point
  {
		//Properties
		protected double y;

		public double Y
		{
			get { return y; }
			set { y = value;}
		}

		//Constructor
		public Point2D(): base()
		{
      y = 0;
    }
		public Point2D(double x, double y): base(x)
		{
      this.y = y;
    }

		//Methods
		public override string ToString()
		{
      return ""+ base.ToString() + ", " + y + "";
    }
		public double GetDistance(Point2D p)
		{
      return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
    }
		//Method to get the midpoint between two points
		public Point2D GetMidPoint(Point2D p)
		{
      return new Point2D((x + p.x) / 2, (y + p.y) / 2);
    }
	}
}
