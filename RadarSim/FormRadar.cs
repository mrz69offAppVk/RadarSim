using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadarSim
{
    public partial class FormRadar : Form
    {
        RadarGraph RadarGraph = new RadarGraph();
        
        public FormRadar()
        {
            InitializeComponent();
            RadarGraph.InitGraphics(pictureBoxRadarSim);
        }

        private void PictureBoxRadarSim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void FormRadar_Resize(object sender, EventArgs e)
        {
            RadarGraph.GetGraphics(pictureBoxRadarSim);
        }

        private void ButtonAddTargets_Click(object sender, EventArgs e)
        {
            RadarGraph.DrawCircle(100, 100, 50);
        }
    }
}
