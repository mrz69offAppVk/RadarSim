using System.Drawing;

namespace Radar
{
    public class TargetObject
    {
        Air air = new Air();
        public int Number;
        public double[,] Traectory;
        public PointF[] XY;

        public double[] Altimeter { get; set; }

        TargetObject(Air air)
        {
            Number = air.Number;
            Traectory = air.Trajectory;
            XY = air.XY;
            this.air = air;
        }
    }
}
