using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class PositionWGS84HP
    {
        double latitude;
        double longitude;

        public PositionWGS84HP(List<string> content)
        {
            double resolutionFactor = (180 / Math.Pow(2, 30));
            string latStr = content[0] + content[1] + content[2] + content[3];
            this.latitude = Utilities.compl2(int.Parse(latStr, System.Globalization.NumberStyles.HexNumber)) * resolutionFactor;
            string longStr = content[4] + content[5] + content[6] + content[7];
            this.longitude = Utilities.compl2(int.Parse(longStr, System.Globalization.NumberStyles.HexNumber)) * resolutionFactor;
        }
        public double getLatitude() { return latitude; }
        public double getLongitude() { return longitude; }
    }
}
