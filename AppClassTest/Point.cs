
namespace AppClassTest
{
  internal class Point
  {
		//Properties
		protected double x;

		public double X
		{
			get { return x; }
			set { x = value; }
		}
		//Constructor - Inicializar las variables de la clase
		public Point()
		{
      x = 0;
    }
		public Point(double x)
		{
      this.x = x;
    }
		//Methods
		public override string ToString()
		{
			return "" + x;
		}
		public double GetDistance(Point p)
		{
      return Math.Abs( x - p.x);
    }
    //Method to get the midpoint between two points
		public Point GetMidPoint(Point p)
		{
      return new Point((x + p.x) / 2);
    }


  }
}
