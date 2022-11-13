using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class TimeOfMessageReceptionPositionHP
    {
        int fullSecondIndication;
        double tomSeconds;

        public TimeOfMessageReceptionPositionHP(DataField dataField)
        {
            int firstOctet = int.Parse(dataField.getDataField()[0], System.Globalization.NumberStyles.HexNumber);
            fullSecondIndication = (firstOctet >> 6) & 0b11;
            string tomStr = (firstOctet & 0b111111).ToString("X") + dataField.getDataField()[1] + dataField.getDataField()[2] + dataField.getDataField()[3];
            double resFactor = Math.Pow(2, -30);
            tomSeconds = int.Parse(tomStr, System.Globalization.NumberStyles.HexNumber) * resFactor;
        }
        public int getFullSecondIndication() { return fullSecondIndication; }
        public double getTomSeconds() { return tomSeconds; }
    }
}
