﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void His(Graphics e, int width, int height, int scale,PointF point,bool mar,bool mar1 ,bool his,int nam,float a,int a1,bool sd, double vys)
        {
            double D1 = 0;
            double A1 = 0;
            double AH = 0;
            double AK = 0;
            double DO = 0;
            double AHO = 0;
            double AKO = 0;
            double VYS = 0;

            PolarCoordinate polar = new PolarCoordinate();
            PointF center = new PointF(width / 2, height / 2);

            float km = (((float)height) / (scale * 10)) / 2;

            double radius = polar.Polar(center, point.X, point.Y)[0];
            double azimut = polar.Polar(center, point.X, point.Y)[1];
            float ps = (float)(1 + (radius / 60));
            float pg = (float)(1 + (radius / 60));
            PointF pf1 = polar.Angel(center, azimut, radius);
            PointF pf2 = polar.Angel(center, azimut, radius + ps);
            PointF pf4 = polar.Angel(center, azimut, radius + ps - pg*2);
            float pe = (float)(10 + (radius / 20));
            float pe1 = (float)(5 + (radius / 20));

            try
            {
                D1  = Coma.radius[a1] / km / 0.4;
                A1  = Coma.azimut[a1] / 0.0878;
                AH  = A1 - 11;
                AK  = A1 + 11;
                AHO = A1 - 22;
                AKO = A1 + 22;
                DO  = D1 + 1;
                VYS = vys;
                if (AH < 0) { AH += 4096; }
                if (AHO < 0) { AHO += 4096; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка приложения!\nMessage: " +
                    ex.Message + '\n' +
                    "StackTrace: " + ex.StackTrace +
                    "\nПриложение будет остановлено",
                    "Radar ERROR"
                    );
            }

            if (a < azimut + 3 && a > azimut - 3)
            {
                try
                {
                    Coma.pf1[a1] = pf1;
                    Coma.pf2[a1] = pf2;
                    Coma.pf4[a1] = pf4;
                    Coma.azimut[a1] = azimut;
                    Coma.radius[a1] = radius;
                    Coma.vys[a1] = vys;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message: " + ex.Message + '\n' + "StackTrace: " + ex.StackTrace, "Radar ERROR");
                }

                if (his == true) { hi = "0"; } else { hi = "1"; }

                if (his == true)
                {
                    Coma.text[nam] = 
                        AH.ToString("0") + "," +
                        AK.ToString("0") + "," +
                        D1.ToString("0") + "," +
                        hi + ","
                        + AHO.ToString("0") + "," +
                        AKO.ToString("0") + "," +
                        DO.ToString("0") + "," +
                        VYS.ToString("0") + ";" + "\r\n"; 
                }
                else
                {
                    Coma.text[nam] = 
                        AH.ToString("0") + "," +
                        AK.ToString("0") + "," +
                        D1.ToString("0") + "," +
                        hi +"," +
                        VYS.ToString("0")+";" + "\r\n";//вывод данных 
                }
            }

            if (sd == true)
            { 
                Coma.pf1[a1] = pf1;
                Coma.pf2[a1] = pf2;
                Coma.pf4[a1] = pf4;
                Coma.azimut[a1] = azimut;
                Coma.radius[a1] = radius;
                Coma.vys[a1] = vys;
            }

            if (Coma.radius[a1] / km < 150 && Coma.radius[a1] / km > 15)
            { 
                e.DrawLine(
                    new Pen(Color.FromArgb(255, 170, 130, 0), pe),
                    Coma.pf1[a1].X,
                    Coma.pf1[a1].Y,
                    Coma.pf2[a1].X,
                    Coma.pf2[a1].Y);
                if (his == true)
                {
                    e.DrawLine(
                        new Pen(Color.FromArgb(255, 170, 130, 0), pe1),
                        Coma.pf1[a1].X,
                        Coma.pf1[a1].Y,
                        Coma.pf4[a1].X,
                        Coma.pf4[a1].Y); }
            }
            if (a == 0)
            { 
                foreach (string bn in Coma.text)
                {
                        Coma.file[Coma.cs] += bn;
                }
                 Coma.cs++; 
            }
            const string Format = "0,0";
            string azimutStr1 = Coma.azimut[a1].ToString(Format);
            string distanceStr1 = (Coma.radius[a1] / km).ToString(Format);
            string altitudeStr1 = Coma.vys[a1].ToString();
            e.DrawString(
                nam + " ) " + 
                " Азимут: " + azimutStr1 + " " +
                "\t Дальность: " + distanceStr1 + " "+
                "\tBысота: " + altitudeStr1,
                    new Font("Consolas", 8), Brushes.White, 10, 40 + (nam * 15)); ;//основное поле

            if (mar == true)
            {
                e.DrawString(nam.ToString(), new Font("Consolas", 8), Brushes.White, Coma.pf1[a1].X - 10, Coma.pf1[a1].Y - 15);
            }

            if (mar1 == true)
            {
                string azimutStr = Coma.azimut[a1].ToString(Format);
                string distanceStr = (Coma.radius[a1] / km).ToString(Format);
                e.DrawString(
                    "Азимут " + azimutStr + "\r\n" +
                    "Дальность " + distanceStr,
                    new Font("Consolas", 8),
                    Brushes.White, Coma.pf1[a1].X, Coma.pf1[a1].Y);
            }
        }
        public void Point(Graphics e, int width, int height,int scale,double azimut,double distance, string text)
        {
            float km = (((float)height) / (scale * 10)) / 2;
            if (Airplane.image != null)
            {
                int CentrImageX = Airplane.image.Width / 2;
                int CentrImageY = Airplane.image.Height / 2;
                e.DrawImage(Airplane.image, 400 - CentrImageX, 400 - CentrImageY);
            }
            double Azimut = azimut;
            double Distance = (km * distance);
            
            PointF point = new PointF(width / 2, height / 2);
            PolarCoordinate polar = new PolarCoordinate();
            PointF pointF = polar.Angel(point, Azimut, Distance);
            double[] ar = polar.Polar(point, pointF.X, pointF.Y);
            //e.DrawString(text+"\n Азимут = " + ar[1].ToString("0")+"\n Дальность = " + (ar[0] / km).ToString("0")  , new Font("Arial", 8), Brushes.White, pointF.X+5, pointF.Y+5);
            Rectangle rectangle = new Rectangle((int)pointF.X - 4, (int)pointF.Y - 4, 8, 8);
            e.FillPie(Brushes.Red, rectangle, 0, 360);
        }
        public void Draw(Graphics e, int width, int height,float angel,int scale,bool on)
        { 
            int coun = scale;
            float SizeEllipse = height / coun;
            float WidthHalf = width / 2;
            float HeilghtHalf = height / 2;
            float SizeEllipse2 = SizeEllipse + 1;
            Rectangle rectangle = new Rectangle((int)(WidthHalf - (SizeEllipse2 *coun) / 2), (int) (HeilghtHalf - (SizeEllipse2 * coun) / 2),(int) (SizeEllipse2*coun),(int) (SizeEllipse2*coun));

            if (on==true)
            {
                for (int x = 0; x < 360; x += 1)
                {
                    e.FillPie(new SolidBrush(Color.FromArgb((int)(x * 0.7), 0, 0, 0)), rectangle, -x + angel-90, 2);
                }
            }
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
                if (ste == 5) 
                {
                    g.DrawEllipse(new Pen(all.colors[1], 1), r);
                    ste = 0; } else { g.DrawEllipse(new Pen(all.colors[0], 1), r);
                }
                if (x == 0) 
                { 
                    g.DrawEllipse(new Pen(all.colors[1], 1), r); 
                }
            }

            for (float i = 0; i < Math.PI * 20; i += (float)Math.PI)
            {
                can++;
                float x1 = WidthHalf + (float)Math.Cos(i * 0.1) * SizeEllipse / 2;
                float y1 = HeilghtHalf + (float)Math.Sin(i * 0.1) * SizeEllipse / 2;
                float x3 = WidthHalf + (float)Math.Cos(i * 0.1) * SizeEllipse * coun / 2;
                float y3 = HeilghtHalf + (float)Math.Sin(i * 0.1) * SizeEllipse * coun / 2;
                if (can == 2) { g.DrawLine(new Pen(all.colors[1], 1), x1, y1, x3, y3); can = 0; } else { g.DrawLine(new Pen(all.colors[0], 1), x1, y1, x3, y3); }
            }
            return bmp;
        }

        internal static void DrawLines(Graphics GRAPH, List<Point> list)
        {
            Pen penWITE = new Pen(Brushes.White);
            GRAPH.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < list.Count-1; i++)
            {
                int pointX1 = list[i].X;
                int pointY1 = list[i].Y;
                int pointX2 = list[i + 1].X;
                int pointY2 = list[i + 1].Y;
                GRAPH.DrawLine(penWITE, pointX1, pointY1, pointX2, pointY2);
            }
        }
    }
}
