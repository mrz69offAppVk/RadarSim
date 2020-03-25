using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radar
{
    public class AllColor
    {
        public Color[] colors = new Color[12];
        public int Bright = 30;
        public AllColor()
        {
            colors[0] = Color.FromArgb(255,70+Bright,50 + Bright, 0);
            colors[1] = Color.FromArgb(255, 140 + Bright, 100 + Bright, 0);
            colors[2] = Color.SkyBlue;
            colors[3] = Color.Green;
            colors[4] = Color.Goldenrod;
            colors[5] = Color.DarkOrange;
            colors[6] = Color.DeepPink;
            colors[7] = Color.Red;
            colors[8] = Color.DarkRed;
            colors[9] = Color.Gray;
            colors[10] = Color.DimGray;
            colors[11] = Color.Black;

        }
    }
}
