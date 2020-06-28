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
        }

        private void PictureBoxRadarSim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void FormRadar_Resize(object sender, EventArgs e)
        {
            RadarGraph.InitGraphics(pictureBoxRadarSim);
            pictureBoxRadarSim.Refresh();
            RadarGraph.GetGraphics(pictureBoxRadarSim);
            RadarGraph.DrawRadarGrid(pictureBoxRadarSim);
        }

        private void ButtonAddTargets_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRadarSim_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void FormRadar_Load(object sender, EventArgs e)
        {

        }
    }
}
