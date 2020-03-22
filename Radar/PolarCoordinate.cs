using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radar
{
    class PolarCoordinate
    {
        /// <summary>
        /// Функция возвращает Х У кординаты по азимуту и радиусу 
        /// </summary>
        /// <param name="Centr"></param>
        /// <param name="angel"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public PointF Angel(PointF Centr,double angel,double radius)
        {
            
            double X, Y;
            double Step = ((Math.PI*200) / 360.0) * (angel-90);
            Y = (Math.Sin(Step * 0.01) * radius) + Centr.Y;
            X = (Math.Cos(Step * 0.01) * radius) + Centr.X;
            PointF pointF = new PointF((float)X,(float) Y);
            return pointF;
        }
        /// <summary>
        /// Функция возвращает [0] радиус [1] угол по кординатам Х У
        /// </summary>
        /// <param name="Centr"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double[] Polar(PointF Centr, double x, double y)
        {
            double[] pc = new double[2];
            double x2;
            double y2;
            double px = x - Centr.X;
            double py = y - Centr.Y;
            double af = 360.0 / 628.0;
            pc[0] = Math.Sqrt((px * px) + (py *py));
            for (int a = 0; a < 628; a++)
            {
                y2 = (Math.Sin((a+471 )* 0.01) * pc[0]) + Centr.Y;
                x2 = (Math.Cos((a+471 ) * 0.01) * pc[0]) + Centr.X;
                if (x2 < x + 2 && x2 > x - 2 && y2 < y + 2 && y2 > y - 2) { pc[1] = af * a; break; }
            }
            return pc;
        }
        /// <summary>
        /// Возврощает длину в км из массива 
        /// </summary>
        /// <param name="Tra"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public double Kilometers(double[,] Tra, int count)
        {
            double km = 0;
            for (int a = 0; a < count - 1; a++)
            {
                double x = Tra[a, 0] - Tra[a + 1, 0];
                double y = Tra[a, 1] - Tra[a + 1, 1];
                km += Math.Sqrt((x * x) + (y * y));
            }
            return km;
        }

        public PointF[] XY(double[,] lines, int width, int height, int scale,int lenght,float speed)
        {
            bool pop = true;
            int cou = 0;
            int ag = 0;
            string g="";
            List<PointF> list = new List<PointF>();
            PointF xy = new PointF();

            for (int r = 0;r<10000;r++)
            {
                bool bx = false;//если тру то ++ если фолс то --
                bool by = false;//если тру то ++ если фолс то --
                bool okx = false;
                bool oky = false;
                float km = (((float)height) / (scale * 10)) / 2;
                
                PointF centr = new PointF(width / 2, height / 2);
                float x5 = Angel(centr,lines[ag, 1],lines[ag, 0] * km).X;
                float y5 = Angel(centr,lines[ag, 1],lines[ag, 0] * km).Y;
                float x6 = Angel(centr,lines[ag + 1, 1],lines[ag + 1, 0] * km).X;
                float y6 = Angel(centr,lines[ag + 1, 1],lines[ag + 1, 0] * km).Y;
                if (pop == true) { xy.X = x5; xy.Y = y5; pop = false; }
                if (x5 < x6) { bx = true; } else { bx = false; }
                if (y5 < y6) { by = true; } else { by = false; }
                if (bx == true) { if (xy.X < x6) { xy.X += speed; } else { okx = true; } } else { if (xy.X > x6) { xy.X -= speed; } else { okx = true; } }
                if (by == true) { if (xy.Y < y6) { xy.Y += speed; } else { oky = true; } } else { if (xy.Y > y6) { xy.Y -= speed; } else { oky = true; } }
                if (okx == true && oky == true) { if (lenght > ag + 2) { ag++; } else { break;  } pop = true; }

                list.Add(xy);
                
            }
            foreach (PointF a in list)
            {
                cou++;
                g +="x = "+ a.X + " y = " + a.Y + "\r\n"; 
            }
            PointF[] ham = new PointF[cou];
            cou = 0;
            foreach (PointF a in list)
            {
                ham[cou] = a;
                cou++;
            }

            return ham;
        }

    }
}
