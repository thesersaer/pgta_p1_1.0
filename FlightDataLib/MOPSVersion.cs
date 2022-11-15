using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class MOPSVersion
    {
        bool versionNotSupported;
        string versionNumber;
        string linkTechnologyType;

        public MOPSVersion(List<string> content)
        {
            int contentInt = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber);
            versionNotSupported = ((contentInt >> 6) & 0b1) != 0;
            int vnInt = ((contentInt >> 3) & 0b111);
            int lttInt = contentInt & 0b111;
            if (lttInt > 3) { linkTechnologyType = "Not assigned"; }
            else if (lttInt > 2) { linkTechnologyType = "VDL 4"; }
            else if (lttInt > 1)
            {
                linkTechnologyType = "1090 ES";
                if (vnInt > 1) { versionNumber = "ED102A/DO-260B [Ref. 11]"; }
                else if (vnInt > 0) { versionNumber = "DO-260A [Ref. 9]"; }
                else { versionNumber = "ED102/DO-260 [Ref. 8]"; }
            }
            else if (lttInt > 0) { linkTechnologyType = "UAT"; }
            else { linkTechnologyType = "Other"; }
        }
        public bool getVersionNotSupported() { return versionNotSupported; }
        public string getVersionNumber() { return versionNumber; }
        public string getLinkTechnologyType() { return linkTechnologyType; }

    }
}
