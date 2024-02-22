using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClassTest
{
  internal class Point3D: Point2D 
  { 
     //Properties
    protected double z;

    public double Z
    {
      get { return z; }
      set { z = value; }
    }

    //Constructor
    public Point3D(): base()
    {
      z = 0;
    }
    public Point3D(double x, double y, double z): base(x, y)
    {
      this.z = z;
    }

    //Methods
    public override string ToString()
    {
      return ""+ base.ToString() + ", " + z + "";
    }
    public double GetDistance(Point3D p)
    {
      return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2) + Math.Pow(z - p.z, 2));
    }
    //obtener el punto medio entre dos puntos
    public Point3D GetMidPoint(Point3D p)
    {
      return new Point3D((x + p.x) / 2, (y + p.y) / 2, (z + p.z) / 2);
    }
  }
}
