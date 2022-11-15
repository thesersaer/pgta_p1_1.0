using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TrackAngleRate
    {
        double trackAngleRate;

        public TrackAngleRate(List<string> content)
        {
            trackAngleRate = Utilities.compl2(int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber)) * (1 / 32);
        }
        public double getTrackAngleRate() { return trackAngleRate; }
    }
}
