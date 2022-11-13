using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class TimeOfApplicabilityVelocity
    {
        double toaSeconds;

        public TimeOfApplicabilityVelocity(DataField dataField)
        {
            string toaStr = dataField.getDataField()[0] + dataField.getDataField()[1] + dataField.getDataField()[2];
            toaSeconds = int.Parse(toaStr, System.Globalization.NumberStyles.HexNumber) * (1 / 128);
        }

        public double getToaSeconds() { return toaSeconds; }
    }
}
