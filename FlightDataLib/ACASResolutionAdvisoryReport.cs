using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class ACASResolutionAdvisoryReport
    {
        int messageType;
        int messageSubtype;
        int activeResolutionAdvisories;
        int raComplementRecord;
        bool raTerminated;
        bool multipleThreatEncounter;
        int threatTypeIndicator;
        int threatIdentityData;

        public ACASResolutionAdvisoryReport(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            messageType = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 3) & 0b11111;
            messageSubtype = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b111;
            int subcInt = int.Parse(content[1] + content[2] + content[3], System.Globalization.NumberStyles.HexNumber);
            activeResolutionAdvisories = (subcInt >> 10) & 0x3FFF;
            raComplementRecord = (subcInt >> 6) & 0b1111;
            raTerminated = ((subcInt >> 5) & 0b1) != 0;
            multipleThreatEncounter = ((subcInt >> 4) & 0b1) != 0;
            threatTypeIndicator = (subcInt >> 2) & 0b11;
            string tidStr = content[3] + content[4] + content[5] + content[6];
            threatIdentityData = int.Parse(tidStr, System.Globalization.NumberStyles.HexNumber) & 0x3FFFFFF;
        }
        public int getMessageType() { return messageType; }
        public int getMessageSubtype() { return messageSubtype; }
        public int getActiveResolutionAdvisories() { return activeResolutionAdvisories; }
        public int getRaComplementRecord() { return raComplementRecord; }
        public bool getRaTerminated() { return raTerminated; }
        public bool getMultipleThreatEncounter() { return multipleThreatEncounter; }
        public int getThreatTypeIndicator() { return threatTypeIndicator; }
        public int getThreatIdentityData() { return threatIdentityData; }
    }
}
