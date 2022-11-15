using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class RollAngle
    {
        double rollAngle; //cw wrt rear view

        public RollAngle(List<string> content)
        {
            rollAngle = Utilities.compl2(int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber)) * 0.01;
        }
        public double getRollAngle() { return rollAngle; }
    }
}
