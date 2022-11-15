using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TrackNumber
    {
        int trackNumber;

        public TrackNumber(List<string> content)
        {
            trackNumber = int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber);
        }
        public int getTrackNumber() { return trackNumber; }
    }
}
