namespace AppClassTest
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      //POINT
      Point a= new Point(); //Declarando y creando el objeto a
      a.X = 10;
      Point b = new Point(15); //Declarando y dando memoria el objeto b
      Point c;//Declarando el objeto c
      c = new Point(15); //Instanciando el objeto c
      Console.WriteLine(a.ToString());
      Point d;
      d = c;
      d.X = 20; 
      Point m = a.GetMidPoint(c);
      Console.WriteLine(m.ToString());
      Console.WriteLine(d.GetDistance(c));
      //POINT 2d
      Point2D e = new Point2D();
      Point2D f = new Point2D(10, 20);
      
      Console.WriteLine(e.GetMidPoint(f).ToString());

      //distance between e and f
      Console.WriteLine(e.GetDistance(f));
      Console.WriteLine(a.GetDistance(new Point(f.X)));
      //POINT 3d
      Point3D g = new Point3D(-10.5,-20,-30);
      Point3D h = new Point3D(10, 20, 30);
      Console.WriteLine(g.GetMidPoint(h).ToString());
      Console.WriteLine("La distancia entre el punto " + g.ToString() + " y el punto "+ h.ToString() +" es = "+g.GetDistance(h));
      //distance between f and h
      Console.WriteLine(f.GetDistance(new Point2D(h.X, h.Y)));


    }
  }
}