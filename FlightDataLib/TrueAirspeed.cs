using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TrueAirspeed
    {
        bool rangeExceeded;
        int trueAirspeed;

        public TrueAirspeed(List<string> content)
        {
            rangeExceeded = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1) != 0;
            string tasStr = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b1111111).ToString("X") + content[1];
            trueAirspeed = int.Parse(tasStr, System.Globalization.NumberStyles.HexNumber);
        }
        public bool getRangeExceeded() { return rangeExceeded; }
        public int getTrueAirspeed() { return trueAirspeed; }
    }
}
