using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class FlightLevel
    {
        double flightLevel;

        public FlightLevel(List<string> content)
        {
            flightLevel = Utilities.compl2(int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber)) * 0.25;
        }
        public double getFlightLevel() { return flightLevel; }
    }
}
