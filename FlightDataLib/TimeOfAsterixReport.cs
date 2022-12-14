using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TimeOfAsterixReport
    {
        double torSeconds;

        public TimeOfAsterixReport(List<string> content)
        {
            string torStr = content[0] + content[1] + content[2];
            torSeconds = int.Parse(torStr, System.Globalization.NumberStyles.HexNumber) * Math.Pow(2, -7);
        }
        public double getToaSeconds() { return torSeconds; }
    }
}
