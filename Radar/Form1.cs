using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            DrawingGrid();
        }
        float a = 0;
        int scale = 15;
        int posX, posY;
        bool on = true;
        bool pop = true;
       
        int ag = 3;
        float cx, cy;
        PointF[] CorX;
        List<PointF[]> buf;
        bool ok = false;
        bool mar = false;
        bool sd;
        int[] cone;
        double[] percent;
        double[] min;
        double[] max;
        int a1 = 0,a2 = 0,a3 = 0,a4=0; Bitmap memoryImage;
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                RadarDraw radar = new RadarDraw();

                e.Graphics.DrawString("Количество целей : " + Com.cons, new Font("Arial", 8), Brushes.White, 10, 10);
                e.Graphics.DrawString("Время " + DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second.ToString(), new Font("Arial", 8), Brushes.White, 10, 25);

                if (ok == true)
                {
                    a1 = 0;
                    foreach (Air air in Com.air)
                    {

                        radar.His(e.Graphics, pictureBox1.Width, pictureBox1.Height, scale, CorX[a1], checkBox2.Checked, checkBox3.Checked, air.His, air.Namber, a, a1, sd);
                        radar.Line(e.Graphics, pictureBox1.Width, pictureBox1.Height, scale, checkBox1.Checked, air.Lenght, air.XY, air.Trajectory);
                        a1++;

                    }

                }
                radar.Draw(e.Graphics, pictureBox1.Width, pictureBox1.Height, a, scale, on);




        }
        void DrawingGrid() {  RadarDraw radar = new RadarDraw();pictureBox1.Image = radar.Grid(pictureBox1.Width, pictureBox1.Height, scale); }
        private void PictureBox1_Resize(object sender, EventArgs e)
        {
         
            pictureBox1.Refresh();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            a+=ag;if (a >= 360) { a = 0; }
            if (ok == true)
            {
                CorX = new PointF[Com.cons];
                a3 = 0;
                foreach (PointF[] ad in buf)
                {
                    if (ad.Length > cone[a3] + 1) { cone[a3]++; CorX[a3] = ad[cone[a3]]; }
                    max[a3] = cone[a3] * percent[a3];
                    a3++;
                }
            }
            pictureBox1.Refresh();sd = false;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ag = 6;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            scale = 7; DrawingGrid(); instal(); 
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            scale = 15; DrawingGrid(); instal(); 
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ag = 3;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Start(); if (on == true) {  } else { on = true; }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (on == true) { on = false; } else {  }
            pictureBox1.Refresh(); timer1.Stop();
        }

        void instal()
        {
            PolarCoordinate polar = new PolarCoordinate();
            a2 = 0;buf = new List<PointF[]>();
            foreach (Air air in Com.air)
            { 
                buf.Add ( polar.XY(air.Trajectory, pictureBox1.Width, pictureBox1.Height, scale,air.Lenght,air.Speed));
                min[a2] = polar.XY(air.Trajectory, pictureBox1.Width, pictureBox1.Height, scale, air.Lenght, air.Speed).Length;
                percent[a2] = 100 / min[a2];
                cone[a2] = (int)(max[a2] / percent[a2]);
                a2++;
            }
           
            ok = true; sd = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true; checkBox2.Checked = true; checkBox3.Checked = true;
            if (on == true) { on = false; } else { }
            pictureBox1.Refresh(); timer1.Stop();
            saveFileDialog1.FileName = "Полет 1";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) { Thread.Sleep(200); }
                Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            memoryImage.Save(saveFileDialog1.FileName + ".jpg");

            timer1.Start(); if (on == true) { } else { on = true; }
            checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {   string stop="";
            timer1.Stop();
            saveFileDialog1.FileName = "Полет 1";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            for(int s = 0; s < Coma.cs; s+=Com.cons)
            {
                    if (s != 0) { stop += Coma.cv + "\r\n" + Coma.file[s].Remove(Coma.file[s].Length-2) + "/" + "\r\n"; }
                    Coma.cv++;
            }
            System.IO.File.WriteAllText(saveFileDialog1.FileName+".txt", stop);
            }
        }



        private void Button5_Click(object sender, EventArgs e)
        {
            Coma.pf1 = new PointF[Com.cons];
            Coma.pf2 = new PointF[Com.cons];
            Coma.pf4 = new PointF[Com.cons];
            Coma.azimut = new double[Com.cons];
            Coma.radius = new double[Com.cons];
            Coma.text = new string[100];
            Coma.file = new string[1000];
            cone = new int[Com.cons];
            percent = new double[Com.cons];
            max = new double[Com.cons];
            min = new double[Com.cons];
            instal();
            timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DrawingGrid(); instal();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            posX = e.X; posY = e.Y;
        }
    }
}
