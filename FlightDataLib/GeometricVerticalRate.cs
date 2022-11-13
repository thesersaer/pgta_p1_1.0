using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class GeometricVerticalRate
    {
        bool rangeExceeded;
        double geometricVerticalRate;

        public GeometricVerticalRate(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            rangeExceeded = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1) != 0;
            string gvrStr = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b1111111).ToString("X") + content[1];
            geometricVerticalRate = Utilities.compl2(int.Parse(gvrStr, System.Globalization.NumberStyles.HexNumber)) * 6.25;
        }
        public bool getRangeExceeded() { return rangeExceeded; }
        public double getGeometricVerticalRate() { return geometricVerticalRate; }
    }
}
