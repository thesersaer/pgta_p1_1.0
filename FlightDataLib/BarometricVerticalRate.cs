using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class BarometricVerticalRate
    {
        bool rangeExceeded;
        double barometricVerticalRate;

        public BarometricVerticalRate(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            rangeExceeded = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1) != 0;
            string bvrStr = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b1111111).ToString("X") + content[1];
            barometricVerticalRate = Utilities.compl2(int.Parse(bvrStr, System.Globalization.NumberStyles.HexNumber)) * 6.25;
        }
        public bool getRangeExceeded() { return rangeExceeded; }
        public double getBarometricVerticalRate() { return barometricVerticalRate; }
    }
}
