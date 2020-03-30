using System.Collections.Generic;
using System.Drawing;

namespace Radar
{
    public class AltiMetro
    {
        public int Number;

        public List<double> Altimeter { get; set; }
        public int TargetObjectNumber { get; set; }

        public AltiMetro()
        {
            Altimeter = new List<double>();
        }

        public AltiMetro(int targetObjectNumber)
        {
            Number = targetObjectNumber;
            Altimeter = new List<double>();
        }
    }
}
