using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DrawingGrid();
        }
        void DrawingGrid() { RadarDraw radar = new RadarDraw(); pictureBox1.BackgroundImage = radar.Grid(pictureBox1.Width, pictureBox1.Height, 15); }
        List<Point> list = new List<Point>();
        bool flag = false;
        Image image;
        double o;
        int ex;
        int ey;
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {               
                if (flag)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    Graphics g = Graphics.FromImage(bmp);
                    list.Add(new Point(e.X, e.Y));
                    g.DrawLines(new Pen(Color.FromArgb(255, 170, 130, 0), 3), list.ToArray());
                    image = pictureBox1.Image = bmp;
                }
                else
                {
                    list.Add(new Point(e.X, e.Y));
                    flag = true;
                }
            }

            ex = e.X;ey = e.Y;
            pictureBox1.Refresh();

        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            list = new List<Point>(); flag = false;

            float km = (((float)pictureBox1.Height) / (15 * 10)) / 2;
            PointF point = new PointF(pictureBox1.Width / 2, pictureBox1.Height / 2);
            PolarCoordinate polar = new PolarCoordinate();
            double[] ar = polar.Polar(point, ex, ey);
            Airplane.StartAzimuth = ar[1];
            Airplane.StartDistance = ar[0] / km;
            textBox2.Text = Airplane.StartAzimuth.ToString();
            textBox3.Text = Airplane.StartDistance.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Airplane.Namber = Convert.ToInt32(textBox1.Text);
            Airplane.Speed = 0.0001f * Convert.ToSingle(textBox6.Text);
            int count = 0;
            PointF point = new PointF(pictureBox1.Width / 2, pictureBox1.Height / 2);
            PolarCoordinate polar = new PolarCoordinate();
            float km = (((float)pictureBox1.Height) / (15 * 10)) / 2;
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
            //air.EndAzimuth = Airplane.EndAzimuth;
            //air.EndDistance = Airplane.EndDistance;
            //air.StartAzimuth = Airplane.StartAzimuth;
            //air.StartDistance = Airplane.StartDistance;
            Com.air.Add(air);
            Com.cons++;
            textBox1.Text = Com.cons.ToString();

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            RadarDraw radar = new RadarDraw();
            if (Airplane.StartAzimuth != o && Airplane.StartDistance != o) { radar.Point(e.Graphics, pictureBox1.Width, pictureBox1.Height, 15, Airplane.StartAzimuth, Airplane.StartDistance, "Начало координат"); }
            if (Airplane.EndAzimuth != o && Airplane.EndDistance != o) { radar.Point(e.Graphics, pictureBox1.Width, pictureBox1.Height, 15, Airplane.EndAzimuth, Airplane.EndDistance, "Конец координат"); }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Airplane.Namber = Convert.ToInt32(textBox1.Text);pictureBox1.Refresh();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Airplane.StartAzimuth = Convert.ToDouble(textBox2.Text); pictureBox1.Refresh();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Airplane.StartDistance = Convert.ToDouble(textBox3.Text); pictureBox1.Refresh();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            Airplane.EndAzimuth = Convert.ToDouble(textBox4.Text); pictureBox1.Refresh();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            Airplane.EndDistance = Convert.ToDouble(textBox5.Text); pictureBox1.Refresh();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Airplane.Speed = 0.0001f * Convert.ToSingle(textBox6.Text); pictureBox1.Refresh();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            float km = (((float)pictureBox1.Height) / (15 * 10)) / 2;
            PointF point = new PointF(pictureBox1.Width / 2, pictureBox1.Height / 2);
            PolarCoordinate polar = new PolarCoordinate();
            double[] ar = polar.Polar(point, ex, ey);
            Airplane.EndAzimuth = ar[1];
            Airplane.EndDistance = ar[0] / km;
            textBox4.Text = Airplane.EndAzimuth.ToString();
            textBox5.Text = Airplane.EndDistance.ToString();
            
            int count = 0;


            foreach (Point h in list)
            {
                count++;
                double[] array = polar.Polar(point, h.X, h.Y);
                

            }
            Airplane.Lenght = count;
            Airplane.Trajectory = new double[count, 2];
            double[,] mile = new double[count, 2];
            count = 0;
            foreach (Point h in list)
            {
                mile[count, 0] = h.X;
                mile[count, 1] = h.Y;
                double[] array = polar.Polar(point, h.X, h.Y);
                Airplane.Trajectory[count, 0] = ar[0] / km;
                Airplane.Trajectory[count, 1] = ar[1];
                count++;
            }
            Airplane.Distance = polar.Kilometers(mile, Airplane.Lenght) / km;
            label1.Text = "Растояние : " + Airplane.Distance.ToString("0.00")+" км";

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Airplane.His = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Airplane.His = false;
        }
    }
}
