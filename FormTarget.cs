using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar
{
    public partial class FormTarget : Form
    {
        Graphics GRAPH;
        public FormTarget()
        {
            InitializeComponent();
            DrawingGrid();
        }
        void DrawingGrid() {
            RadarDraw radar = new RadarDraw();
            pictureBoxTarget.BackgroundImage = radar.Grid(pictureBoxTarget.Width, pictureBoxTarget.Height, 15);
            pictureBoxTarget.Image = pictureBoxTarget.BackgroundImage;
            image = pictureBoxTarget.Image;
            GRAPH = Graphics.FromImage(image);
        }

        List<Point> list = new List<Point>();
        bool flag = false;
        bool targetStarted = false; // этот флаг обозначает что начата прокладка курса и клики должны обрабатываться добавлением точек в лист
        double oAzimut;
        int ex;
        int ey;
        Image image;
        private bool targetEnd = false; // этот флаг обозначает, что последний клик по картинке завершает создание цели
        int targetObjectNumber = 0; // Нумерация создаваемых целей

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Airplane.Namber = Convert.ToInt32(textBoxTargetNum.Text);
            Airplane.Speed = 0.0001f * Convert.ToSingle(textBox6.Text);
            int count = 0;
            PointF point = new PointF(pictureBoxTarget.Width / 2, pictureBoxTarget.Height / 2);
            PolarCoordinate polar = new PolarCoordinate();
            float km = (((float)pictureBoxTarget.Height) / (15 * 10)) / 2;
            foreach (Point h in list)
            {
                count++;
                double[] ar = polar.Polar(point, h.X, h.Y);
            }
            Airplane.Lenght = count;
            Airplane.Trajectory = new double[count, 2];
            count = 0;
            foreach (Point h in list)
            {
                double[] ar = polar.Polar(point, h.X, h.Y);
                Airplane.Trajectory[count, 0] = ar[0] / km;
                Airplane.Trajectory[count, 1] = ar[1];
                count++;
            }
            Airplane.Hi = true;
            Air air = new Air();
            air.Namber = Airplane.Namber;
            air.Lenght = Airplane.Lenght;
            air.Speed = Airplane.Speed;
            air.His = Airplane.His;
            air.Distance = Airplane.Distance;
            air.Trajectory = Airplane.Trajectory;
            air.XY = Airplane.XY;
            air.vys = Airplane.vys;
            //air.EndAzimuth = Airplane.EndAzimuth;
            //air.EndDistance = Airplane.EndDistance;
            //air.StartAzimuth = Airplane.StartAzimuth;
            //air.StartDistance = Airplane.StartDistance;
            Com.air.Add(air);
            Com.cons++;
            textBoxTargetNum.Text = Com.cons.ToString();
        }

        private void PictureBoxTarget_Paint(object sender, PaintEventArgs e)
        {
            RadarDraw radar = new RadarDraw();
            if (Airplane.StartAzimuth != oAzimut && Airplane.StartDistance != oAzimut)
            {
                radar.Point(e.Graphics, pictureBoxTarget.Width, pictureBoxTarget.Height, 15, Airplane.StartAzimuth, Airplane.StartDistance, "Начало координат");
            }
            if (Airplane.EndAzimuth != oAzimut && Airplane.EndDistance != oAzimut) { radar.Point(e.Graphics, pictureBoxTarget.Width, pictureBoxTarget.Height, 15, Airplane.EndAzimuth, Airplane.EndDistance, "Конец координат"); }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Airplane.Namber = Convert.ToInt32(textBoxTargetNum.Text);pictureBoxTarget.Refresh();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Airplane.StartAzimuth = Convert.ToDouble(textBoxAzimut.Text); pictureBoxTarget.Refresh();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Airplane.StartDistance = Convert.ToDouble(textBoxDistance.Text); pictureBoxTarget.Refresh();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            Airplane.EndAzimuth = Convert.ToDouble(textBox4.Text); pictureBoxTarget.Refresh();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            Airplane.EndDistance = Convert.ToDouble(textBox5.Text); pictureBoxTarget.Refresh();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Airplane.Speed = 0.0001f * Convert.ToSingle(textBox6.Text); pictureBoxTarget.Refresh();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Airplane.His = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Airplane.His = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Airplane.vys = Convert.ToDouble(textBox7.Text); pictureBoxTarget.Refresh(); 
        }

        #region mouse event
        //private void PictureBoxTarget_MouseDown(object sender, MouseEventArgs e)
        //{
        //    list = new List<Point>(); flag = false;
        //    float km = (((float)pictureBoxTarget.Height) / (15 * 10)) / 2;
        //    PointF point = new PointF(pictureBoxTarget.Width / 2, pictureBoxTarget.Height / 2);
        //    PolarCoordinate polar = new PolarCoordinate();
        //    double[] ar = polar.Polar(point, ex, ey);
        //    Airplane.StartAzimuth = ar[1];
        //    Airplane.StartDistance = ar[0] / km;
        //    textBox2.Text = Airplane.StartAzimuth.ToString();
        //    textBox3.Text = Airplane.StartDistance.ToString();
        //}

        //private void PictureBoxTarget_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        if (flag)
        //        {
        //            Bitmap bmp = new Bitmap(pictureBoxTarget.Width, pictureBoxTarget.Height);
        //            Graphics g = Graphics.FromImage(bmp);
        //            list.Add(new Point(e.X, e.Y));
        //            g.DrawLines(new Pen(Color.FromArgb(255, 170, 130, 0), 3), list.ToArray());
        //            image = pictureBoxTarget.Image = bmp;
        //        }
        //        else
        //        {
        //            list.Add(new Point(e.X, e.Y));
        //            flag = true;
        //        }
        //    }
        //    ex = e.X; ey = e.Y;
        //    pictureBoxTarget.Refresh();
        //}

        //private void PictureBoxTarget_MouseUp(object sender, MouseEventArgs e)
        //{
        //    float km = (((float)pictureBoxTarget.Height) / (15 * 10)) / 2;
        //    PointF point = new PointF(pictureBoxTarget.Width / 2, pictureBoxTarget.Height / 2);
        //    PolarCoordinate polar = new PolarCoordinate();
        //    double[] ar = polar.Polar(point, ex, ey);
        //    Airplane.EndAzimuth = ar[1];
        //    Airplane.EndDistance = ar[0] / km;
        //    textBox4.Text = Airplane.EndAzimuth.ToString();
        //    textBox5.Text = Airplane.EndDistance.ToString();
        //    textBox7.Text = Airplane.vys.ToString();

        //    int count = 0;

        //    foreach (Point h in list)
        //    {
        //        count++;
        //        double[] array = polar.Polar(point, h.X, h.Y);
        //    }
        //    Airplane.Lenght = count;
        //    Airplane.Trajectory = new double[count, 2];
        //    double[,] mile = new double[count, 2];
        //    count = 0;
        //    foreach (Point h in list)
        //    {
        //        mile[count, 0] = h.X;
        //        mile[count, 1] = h.Y;
        //        double[] array = polar.Polar(point, h.X, h.Y);
        //        Airplane.Trajectory[count, 0] = ar[0] / km;
        //        Airplane.Trajectory[count, 1] = ar[1];
        //        count++;
        //    }
        //    Airplane.Distance = polar.Kilometers(mile, Airplane.Lenght) / km;
        //    label1.Text = "Растояние : " + Airplane.Distance.ToString("0.00") + " км";

        //}

        private void pictureBoxTarget_MouseClick(object sender, MouseEventArgs e)
        {
            if (!targetStarted)
            {
                TargetStart(e);
            }
            else if(targetStarted && !targetEnd)
            {
                TargetContinue(e);
            }
        }

        private void TargetStart(MouseEventArgs e)
        {
            targetObjectNumber++;
            list = new List<Point>(); flag = false;
            float km = (((float)pictureBoxTarget.Height) / (15 * 10)) / 2;
            PointF point = new PointF(pictureBoxTarget.Width / 2, pictureBoxTarget.Height / 2);
            PolarCoordinate polar = new PolarCoordinate();
            double[] ar = polar.Polar(point, e.X, e.Y);
            Airplane.StartAzimuth = ar[1];
            Airplane.StartDistance = ar[0] / km;
            Point targetPoint = new Point(e.X, e.Y);
            list.Add(targetPoint);
            textBoxAzimut.Text = Airplane.StartAzimuth.ToString();
            textBoxDistance.Text = Airplane.StartDistance.ToString();
            targetStarted = true;
        }
        private void TargetContinue(MouseEventArgs e)
        {
            RadarDraw RD = new RadarDraw();
            //flag = false;
            float km = (((float)pictureBoxTarget.Height) / (15 * 10)) / 2;
            PointF point = new PointF(pictureBoxTarget.Width / 2, pictureBoxTarget.Height / 2);
            PolarCoordinate polar = new PolarCoordinate();
            double[] ar = polar.Polar(point, e.X, e.Y);
            Airplane.StartAzimuth = ar[1];
            Airplane.StartDistance = ar[0] / km;
            Point targetPoint = new Point(e.X, e.Y);
            string targetPointString = targetPoint.X.ToString() + ' ' + targetPoint.Y.ToString() + '\n';
            File.AppendAllText($"target{targetObjectNumber}.ini", targetPointString);
            list.Add(targetPoint);
            if (list.Count > 1)
                { RadarDraw.DrawLines(GRAPH, list); }
            textBoxAzimut.Text = Airplane.StartAzimuth.ToString();
            textBoxDistance.Text = Airplane.StartDistance.ToString();

        }
        #endregion mouse event
    }
}
