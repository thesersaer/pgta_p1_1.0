using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class PositionWGS84
    {
        double latitude;
        double longitude;

        public PositionWGS84(List<string> content)
        {
            double resolutionFactor = (180 / Math.Pow(2, 23));
            string latStr = content[0] + content[1] + content[2];
            this.latitude = Utilities.compl2(int.Parse(latStr, System.Globalization.NumberStyles.HexNumber)) * resolutionFactor;
            string longStr = content[3] + content[4] + content[5];
            this.longitude = Utilities.compl2(int.Parse(longStr, System.Globalization.NumberStyles.HexNumber)) * resolutionFactor;
        }
        public double getLatitude() { return latitude; }
        public double getLongitude() { return longitude; }
    }
}
