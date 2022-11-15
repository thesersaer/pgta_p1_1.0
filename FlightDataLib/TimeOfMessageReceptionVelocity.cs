using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TimeOfMessageReceptionVelocity
    {
        double tomSeconds;

        public TimeOfMessageReceptionVelocity(List<string> content)
        {
            string tomStr = content[0] + content[1] + content[2];
            tomSeconds = int.Parse(tomStr, System.Globalization.NumberStyles.HexNumber) * Math.Pow(2, -7);
        }
        public double getToaSeconds() { return tomSeconds; }
    }
}
