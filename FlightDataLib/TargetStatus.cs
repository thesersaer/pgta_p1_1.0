using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TargetStatus
    {
        bool intentChangeFlag;
        bool lnavModeNotEngaged;
        string priorityStatus;
        string surveillanceStatus;

        public TargetStatus(List<string> content)
        {
            intentChangeFlag = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1) != 0;
            lnavModeNotEngaged = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 6) & 0b1) != 0;
            int psInt = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 2) & 0b111;
            if (psInt == 0) { priorityStatus = "No emergency / Not reported"; }
            else if (psInt == 1) { priorityStatus = "General emergency"; }
            else if (psInt == 2) { priorityStatus = "Lifeguard / medical emergency"; }
            else if (psInt == 3) { priorityStatus = "Minimum fuel"; }
            else if (psInt == 4) { priorityStatus = "No communications"; }
            else if (psInt == 5) { priorityStatus = "Unlawful interference"; }
            else { priorityStatus = "Downed aircraft"; }
            int ssInt = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b11;
            if (ssInt == 0) { surveillanceStatus = "No condition reported"; }
            else if (ssInt == 1) { surveillanceStatus = "Permanent Alert"; }
            else if (ssInt == 2) { surveillanceStatus = "Temporary Alert"; }
            else { surveillanceStatus = "SPI set"; }
        }
        public bool getIntentChangeFlag() { return intentChangeFlag; }
        public bool getLnavModeNotEngaged() { return lnavModeNotEngaged; }
        public string getPriorityStatus() { return priorityStatus; }
        public string getSurveillanceStatus() { return surveillanceStatus; }
    }
}
