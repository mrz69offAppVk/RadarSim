using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radar
{
    class TrainingObject
    {
        PolarCoordinate polarCoordinate = new PolarCoordinate();
        int targetNum { get; set; }

        int pointNum;

        PointF pointClick;

        //TrainingObject() { }

        public TrainingObject(int pointNum, int target, PointF Center, double x, double y)
        {
            double[] pointPolar = polarCoordinate.GetPolar(Center, x, y);
            targetNum = target;
        }
    }
}
