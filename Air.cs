using System.Drawing;

namespace Radar
{
    public class Air
    {
      public int Number;
      public int Lenght;
      public double StartAzimuth;
      public double StartDistance;
      public double EndAzimuth;
      public double EndDistance;
      public float Speed;
      public bool His = true;
      public bool Hi;
      public Image image;
      public double[,] Trajectory;
      public PointF[] XY;
      public double Distance;
      public double[] vys;
    }
}
