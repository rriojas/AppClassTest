
namespace AppClassTest
{
  internal class Point
  {
		//Properties
		protected int x;

		public int X
		{
			get { return x; }
			set { x = value; }
		}
		//Constructor - Inicializar las variables de la clase
		public Point()
		{
      x = 0;
    }
		public Point(int x)
		{
      this.x = x;
    }
		//Methods
		public override string ToString()
		{
			return "X: " + x;
		}
		public int GetDistance(Point p)
		{
      return Math.Abs( x - p.x);
    }

	}
}
