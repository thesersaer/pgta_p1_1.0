using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class TimeOfMessageReceptionPosition
    {
        double tomSeconds;

        public TimeOfMessageReceptionPosition(DataField dataField)
        {
            string tomStr = dataField.getDataField()[0] + dataField.getDataField()[1] + dataField.getDataField()[2];
            tomSeconds = int.Parse(tomStr, System.Globalization.NumberStyles.HexNumber) * (1 / 128);
        }

        public double getToaSeconds() { return tomSeconds; }
    }
}
