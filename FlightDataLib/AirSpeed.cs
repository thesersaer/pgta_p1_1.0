using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class AirSpeed
    {
        string im;
        double airSpeed;

        public AirSpeed(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            int imBit = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1);
            string asStr = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b1111111).ToString("X") + content[1];
            airSpeed = int.Parse(asStr, System.Globalization.NumberStyles.HexNumber);
            if (imBit != 0)
            {
                im = "mach";
                airSpeed *= 0.001;
            }
            else
            {
                im = "ias";
                airSpeed *= Math.Pow(2, -14);
            }
        }
        public string getIm() { return im; }
        public double getAirSpeed() { return airSpeed; }
    }
}
