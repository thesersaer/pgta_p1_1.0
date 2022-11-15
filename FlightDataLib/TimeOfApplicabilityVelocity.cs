using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TimeOfApplicabilityVelocity
    {
        double toaSeconds;

        public TimeOfApplicabilityVelocity(List<string> content)
        {
            string toaStr = content[0] + content[1] + content[2];
            toaSeconds = int.Parse(toaStr, System.Globalization.NumberStyles.HexNumber) * (1 / 128);
        }

        public double getToaSeconds() { return toaSeconds; }
    }
}
