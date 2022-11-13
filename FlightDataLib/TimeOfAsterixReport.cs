using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLib;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TimeOfAsterixReport
    {
        double torSeconds;

        public TimeOfAsterixReport(DataField dataField)
        {
            string torStr = dataField.getDataField()[0] + dataField.getDataField()[1] + dataField.getDataField()[2];
            torSeconds = int.Parse(torStr, System.Globalization.NumberStyles.HexNumber) * Math.Pow(2, -7);
        }
        public double getToaSeconds() { return torSeconds; }
    }
}
