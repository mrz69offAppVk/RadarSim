using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RadarSim
{
    class RadarGraph
    {
        const int distanceStepsCount= 15;
        public float distanceStepSize;
        public float radarRadius;
        Graphics graphics;
        Bitmap bitmap;
        Image image;
        public PointF centerPointF;
        public Pen penGreen = new Pen(Color.FromArgb(100, 0, 255, 0),0.25F);
        
        public void InitGraphics(PictureBox pictureBoxRadarSim)
        {
            centerPointF.X = pictureBoxRadarSim.Width / 2;
            centerPointF.Y = pictureBoxRadarSim.Height / 2;
            distanceStepSize = (pictureBoxRadarSim.Height / 2) / 15;
            radarRadius = pictureBoxRadarSim.Height / 2;
            bitmap = new Bitmap(pictureBoxRadarSim.Width, pictureBoxRadarSim.Height);
            pictureBoxRadarSim.Image = bitmap;
            graphics = Graphics.FromHwnd(pictureBoxRadarSim.Handle);
            graphics.Clear(Color.Black);
            pictureBoxRadarSim.BackColor = Color.Black;
        }

        internal void DrawCircle(float xCenter, float yCenter, float radius)
        {
            graphics.DrawEllipse(penGreen, xCenter - radius, yCenter - radius, 2 * radius, 2 * radius);
        }

        internal void GetGraphics(PictureBox pictureBoxRadarSim)
        {
            radarRadius = pictureBoxRadarSim.Height / 2;
            image = pictureBoxRadarSim.Image;
        }

        internal void DrawRadarGrid(PictureBox pictureBoxRadarSim)
        {
            for (int i = 1; i < distanceStepsCount; i++)
            {
                DrawCircle(centerPointF.X, centerPointF.Y, distanceStepSize*i);
            }
        }
    }
}
