using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class FinalStateSelectedAltitude
    {
        bool manageVerticalModeActive;
        bool altitudeHoldModeActive;
        bool approachModeActive;
        int altitude;

        public FinalStateSelectedAltitude(List<string> content)
        {
            manageVerticalModeActive = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1) != 0;
            altitudeHoldModeActive = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 6) & 0b1) != 0;
            approachModeActive = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 5) & 0b1) != 0;
            string altStr = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b11111).ToString("X") + content[1];
            altitude = Utilities.compl2(int.Parse(altStr, System.Globalization.NumberStyles.HexNumber)) * 25;
        }
        public bool getManageVerticalModeActive() { return manageVerticalModeActive; }
        public bool getAltitudeHoldModeActive() { return altitudeHoldModeActive; }
        public bool getApproachModeActive() { return approachModeActive; }
        public int getAltitude() { return altitude; }
    }
}
