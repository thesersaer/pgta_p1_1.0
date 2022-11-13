using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class TimeOfMessageReceptionVelocity
    {
        double tomSeconds;

        public TimeOfMessageReceptionVelocity(DataField dataField)
        {
            string tomStr = dataField.getDataField()[0] + dataField.getDataField()[1] + dataField.getDataField()[2];
            tomSeconds = int.Parse(tomStr, System.Globalization.NumberStyles.HexNumber) * Math.Pow(2, -7);
        }
        public double getToaSeconds() { return tomSeconds; }
    }
}
