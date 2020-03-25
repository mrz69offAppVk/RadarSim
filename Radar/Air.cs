using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radar
{
    public class Air
    {
      public int Namber;
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
    }
}
