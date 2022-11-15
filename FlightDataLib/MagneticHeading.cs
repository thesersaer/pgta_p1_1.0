using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class MagneticHeading
    {
        double magneticHeading;

        public MagneticHeading(List<string> content)
        {
            magneticHeading = int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber) * (360 / Math.Pow(2, 16));
        }
        public double getMagneticHeading() { return magneticHeading; }
    }
}
