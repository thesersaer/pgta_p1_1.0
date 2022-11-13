using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class AirboneGroundVector
    {
        bool rangeExceeded;
        double groundSpeed;
        double trackAngle; //cw wrt true north

        public AirboneGroundVector(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            rangeExceeded = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1) != 0;
            string gsStr = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b1111111).ToString("X") + content[1];
            groundSpeed = int.Parse(gsStr, System.Globalization.NumberStyles.HexNumber) * Math.Pow(2, -14);
            trackAngle = int.Parse(content[2] + content[3], System.Globalization.NumberStyles.HexNumber) * (360 / Math.Pow(2, 16));
        }
        public bool getRangeExceeded() { return rangeExceeded; }
        public double getGroundSpeed() { return groundSpeed; }
        public double getTrackAngle() { return trackAngle; }
    }
}
