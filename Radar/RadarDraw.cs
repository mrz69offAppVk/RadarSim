using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radar
{
    class RadarDraw
    {

        string hi;
        
        public void Line(Graphics e, int width, int height, int scale, bool mar, int Lenght , PointF[] XY,double[,] Trajectory)
        {
            float km = (((float)height) / (scale * 10)) / 2;
            PointF centr = new PointF(width / 2, height / 2);
            XY = new PointF[Lenght];
            PolarCoordinate polar = new PolarCoordinate();
            for (int a = 0; a < Lenght; a++)
            {
                XY[a] = polar.Angel(centr, Trajectory[a, 1], Trajectory[a, 0] * km);
            }
            if (mar == true) { e.DrawLines(Pens.White, XY); }

        }
        public void His(Graphics e, int width, int height, int scale,PointF point,bool mar,bool mar1 ,bool his,int nam,float a,int a1,bool sd)
        {
            // float km = (((float)height) / (scale * 10)) / 2;


            PointF centr = new PointF(width / 2, height / 2);
            PolarCoordinate polar = new PolarCoordinate();

            float km = (((float)height) / (scale * 10)) / 2;
            double radius = polar.Polar(centr, point.X, point.Y)[0];
            double azimut = polar.Polar(centr, point.X, point.Y)[1];
            float ps = (float)(1 + (radius / 60));
            float pg = (float)(1 + (radius / 60));
            PointF pf1 = polar.Angel(centr, azimut, radius);
            PointF pf2 = polar.Angel(centr, azimut, radius + ps);
            PointF pf4 = polar.Angel(centr, azimut, radius + ps - pg*2);
            float pe = (float)(10 + (radius / 20));
            float pe1 = (float)(5 + (radius / 20));
            double D1 = (Coma.radius[a1] / km) / 0.4;
            double A1 = Coma.azimut[a1] / 0.0878;
            double AH = A1 - 11;
            double AK = A1 + 11;
            double AHO = A1 - 22;
            double AKO = A1 + 22;
            double DO = D1 + 1;

            if (AH < 0) { AH += 4096; }
            if (AHO < 0) { AHO += 4096; }
            if (a<azimut+3&&a>azimut-3)
            {
              
                Coma.pf1[a1] = pf1; Coma.pf2[a1] = pf2; Coma.pf4[a1] = pf4;Coma.azimut[a1] = azimut; Coma.radius[a1] = radius;
                if (his == true) { hi = "0"; } else { hi = "1"; }

                if (his == true)
                {
                    Coma.text[nam] = AH.ToString("0") + "," + AK.ToString("0") + "," + D1.ToString("0") + ","+hi+","+AHO.ToString("0") + ","+AKO.ToString("0") + ","+DO.ToString("0") + ";"+"\r\n"; 
                }
                else
                {
                    Coma.text[nam] = AH.ToString("0") + "," + AK.ToString("0") + "," + D1.ToString("0") + "," + hi + ";" + "\r\n"; 
                }

                

            }
            if (sd == true) { Coma.pf1[a1] = pf1; Coma.pf2[a1] = pf2; Coma.pf4[a1] = pf4; Coma.azimut[a1] = azimut; Coma.radius[a1] = radius;  }

            if (Coma.radius[a1] / km<150 && Coma.radius[a1] / km > 15) { 
            e.DrawLine(new Pen(Color.FromArgb(255, 170, 130, 0), pe), Coma.pf1[a1].X, Coma.pf1[a1].Y, Coma.pf2[a1].X, Coma.pf2[a1].Y);
            if (his == true) {e.DrawLine(new Pen(Color.FromArgb(255, 170, 130, 0), pe1), Coma.pf1[a1].X, Coma.pf1[a1].Y, Coma.pf4[a1].X, Coma.pf4[a1].Y); }}

            if (a == 0)
            {
                
            foreach (string bn in Coma.text)
            {
                    Coma.file[Coma.cs] += bn;
            }
               
                 Coma.cs++; 
            }
            

            e.DrawString(nam + " ) " + "Азимут " + Coma.azimut[a1].ToString("0.000") + "  " + "Дальность " + (Coma.radius[a1] / km).ToString("0.000"), new Font("Arial", 8), Brushes.White, 10, 40+(nam*15));
            if (mar == true)
            {
                e.DrawString(nam.ToString(), new Font("Arial", 8), Brushes.White, Coma.pf1[a1].X - 10, Coma.pf1[a1].Y - 15);
            }

            if (mar1 == true)
            {
                e.DrawString("Азимут "+ Coma.azimut[a1].ToString("0")+"\r\n"+"Дальность "+(Coma.radius[a1] / km).ToString("0"), new Font("Arial", 8), Brushes.White, Coma.pf1[a1].X , Coma.pf1[a1].Y );
            }
        }
        public void Point(Graphics e, int width, int height,int scale,double a,double d,string text)
        {
            float km = (((float)height) / (scale * 10)) / 2;
            if (Airplane.image != null)
            {
                int CentrImageX = Airplane.image.Width / 2;
                int CentrImageY = Airplane.image.Height / 2;
                e.DrawImage(Airplane.image, 400 - CentrImageX, 400 - CentrImageY);
            }
            double Azimut = a;
            double Distance = (km * d);
            PointF point = new PointF(width / 2, height / 2);
            PolarCoordinate polar = new PolarCoordinate();
            PointF pointF = polar.Angel(point, Azimut, Distance);
            double[] ar = polar.Polar(point, pointF.X, pointF.Y);
            e.DrawString(text+"\n Азимут = " + ar[1].ToString("0")+"\n Дальность = " + (ar[0] / km).ToString("0")  , new Font("Arial", 8), Brushes.White, pointF.X+5, pointF.Y+5);
            Rectangle re = new Rectangle((int)pointF.X,(int)pointF.Y, 4, 4);
            e.FillPie(Brushes.Red, re,0,360);
        }
        public void Draw(Graphics e, int width, int height,float angel,int scale,bool on)
        { 
            int coun = scale;
            float SizeEllipse = height / coun;
            float WidthHalf = width / 2;
            float HeilghtHalf = height / 2;
            float SizeEllipse2 = SizeEllipse + 1;
            Rectangle rectangle = new Rectangle((int)(WidthHalf - (SizeEllipse2 *coun) / 2), (int) (HeilghtHalf - (SizeEllipse2 * coun) / 2),(int) (SizeEllipse2*coun),(int) (SizeEllipse2*coun));
            if (on==true){  for (int x = 0; x < 360; x += 1){e.FillPie(new SolidBrush(Color.FromArgb((int)(x * 0.7), 0, 0, 0)), rectangle, -x + angel-90, 2);}}
        }

        public Image Grid(int width , int height, int scale)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            AllColor all = new AllColor();
            int coun = scale;
            float SizeEllipse = height / coun;
            float WidthHalf = width / 2;
            float HeilghtHalf = height / 2;
            int ste = 0;int can = 0;
            for (float x = 0; x < SizeEllipse * coun; x += SizeEllipse)
            {
                ste++;
                RectangleF r = new RectangleF(WidthHalf - (SizeEllipse + x) / 2, HeilghtHalf - (SizeEllipse + x) / 2, SizeEllipse + x, SizeEllipse + x);
                if (ste == 5) { g.DrawEllipse(new Pen(all.colors[1], 1), r); ste = 0; } else { g.DrawEllipse(new Pen(all.colors[0], 1), r); }
                if (x == 0) { g.DrawEllipse(new Pen(all.colors[1], 1), r); }
            }
            float  x1 = 0, y1 = 0,x3 = 0, y3 = 0;
            for (float i = 0; i < Math.PI * 20; i += (float)Math.PI)
            {
                can++;
                x1 = WidthHalf + (float)Math.Cos(i * 0.1) * SizeEllipse / 2;
                y1 = HeilghtHalf + (float)Math.Sin(i * 0.1) * SizeEllipse / 2;
                x3 = WidthHalf + (float)Math.Cos(i * 0.1) * SizeEllipse * coun / 2;
                y3 = HeilghtHalf + (float)Math.Sin(i * 0.1) * SizeEllipse * coun / 2;
                if (can == 2) { g.DrawLine(new Pen(all.colors[1], 1), x1, y1, x3, y3); can = 0; } else { g.DrawLine(new Pen(all.colors[0], 1), x1, y1, x3, y3); }
            }
            return bmp;
        }

        //public Image Scrin(int width, int height, int scale, PointF point, bool mar, bool mar1, bool his, int nam, float a, int a1, bool sd)
        //{
        //    Bitmap bmp = new Bitmap(width, height);
        //    Graphics g = Graphics.FromImage(bmp);
        //    g.SmoothingMode = SmoothingMode.AntiAlias;
        //    AllColor all = new AllColor();
        //    int coun = scale;
        //    float SizeEllipse = height / coun;
        //    float WidthHalf = width / 2;
        //    float HeilghtHalf = height / 2;
        //    int ste = 0; int can = 0;
        //    for (float x = 0; x < SizeEllipse * coun; x += SizeEllipse)
        //    {
        //        ste++;
        //        RectangleF r = new RectangleF(WidthHalf - (SizeEllipse + x) / 2, HeilghtHalf - (SizeEllipse + x) / 2, SizeEllipse + x, SizeEllipse + x);
        //        if (ste == 5) { g.DrawEllipse(new Pen(all.colors[1], 1), r); ste = 0; } else { g.DrawEllipse(new Pen(all.colors[0], 1), r); }
        //        if (x == 0) { g.DrawEllipse(new Pen(all.colors[1], 1), r); }
        //    }
        //    float x1 = 0, y1 = 0, x3 = 0, y3 = 0;
        //    for (float i = 0; i < Math.PI * 20; i += (float)Math.PI)
        //    {
        //        can++;
        //        x1 = WidthHalf + (float)Math.Cos(i * 0.1) * SizeEllipse / 2;
        //        y1 = HeilghtHalf + (float)Math.Sin(i * 0.1) * SizeEllipse / 2;
        //        x3 = WidthHalf + (float)Math.Cos(i * 0.1) * SizeEllipse * coun / 2;
        //        y3 = HeilghtHalf + (float)Math.Sin(i * 0.1) * SizeEllipse * coun / 2;
        //        if (can == 2) { g.DrawLine(new Pen(all.colors[1], 1), x1, y1, x3, y3); can = 0; } else { g.DrawLine(new Pen(all.colors[0], 1), x1, y1, x3, y3); }
        //    }




        //    PointF centr = new PointF(width / 2, height / 2);
        //    PolarCoordinate polar = new PolarCoordinate();

        //    float km = (((float)height) / (scale * 10)) / 2;
        //    double radius = polar.Polar(centr, point.X, point.Y)[0];
        //    double azimut = polar.Polar(centr, point.X, point.Y)[1];
        //    float ps = (float)(1 + (radius / 60));
        //    float pg = (float)(1 + (radius / 60));
        //    PointF pf1 = polar.Angel(centr, azimut, radius);
        //    PointF pf2 = polar.Angel(centr, azimut, radius + ps);
        //    PointF pf4 = polar.Angel(centr, azimut, radius + ps - pg * 2);
        //    float pe = (float)(10 + (radius / 20));
        //    float pe1 = (float)(5 + (radius / 20));

        //    if (a < azimut + 3 && a > azimut - 3)
        //    {
        //        Coma.pf1[a1] = pf1; Coma.pf2[a1] = pf2; Coma.pf4[a1] = pf4; Coma.azimut[a1] = azimut; Coma.radius[a1] = radius;
        //        if (his == true) { hi = "0"; } else { hi = "1"; }

        //        Coma.text[a1] += Coma.azimut[a1].ToString("0.000") + "," + (Coma.radius[a1] / km).ToString("0.000") + "," + hi + ";";

        //    }
        //    if (sd == true) { Coma.pf1[a1] = pf1; Coma.pf2[a1] = pf2; Coma.pf4[a1] = pf4; Coma.azimut[a1] = azimut; Coma.radius[a1] = radius; }

        //    if (Coma.radius[a1] / km < 150 && Coma.radius[a1] / km > 15)
        //    {
        //        g.DrawLine(new Pen(Color.FromArgb(255, 170, 130, 0), pe), Coma.pf1[a1].X, Coma.pf1[a1].Y, Coma.pf2[a1].X, Coma.pf2[a1].Y);
        //        if (his == true) { g.DrawLine(new Pen(Color.FromArgb(255, 170, 130, 0), pe1), Coma.pf1[a1].X, Coma.pf1[a1].Y, Coma.pf4[a1].X, Coma.pf4[a1].Y); }
        //    }



        //    g.DrawString(nam + " ) " + "Азимут " + Coma.azimut[a1].ToString("0.000") + "  " + "Далность " + (Coma.radius[a1] / km).ToString("0.000"), new Font("Arial", 8), Brushes.White, 10, 40 + (nam * 15));
       
        //    g.DrawString(nam.ToString(), new Font("Arial", 8), Brushes.White, Coma.pf1[a1].X - 10, Coma.pf1[a1].Y - 15);
           

          
        //   g.DrawString("Азимут " + Coma.azimut[a1].ToString("0") + "\r\n" + "Далность " + (Coma.radius[a1] / km).ToString("0"), new Font("Arial", 8), Brushes.White, Coma.pf1[a1].X, Coma.pf1[a1].Y);
            











        //    return bmp;
        //}
    }
}
