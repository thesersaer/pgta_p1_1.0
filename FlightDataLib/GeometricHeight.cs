using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class GeometricHeight
    {
        double geometricHeight;

        public GeometricHeight(List<string> content)
        {
            this.geometricHeight = Utilities.compl2(int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber)) * 6.25;
        }
        public double getGeometricHeight() { return geometricHeight; }
    }
}
