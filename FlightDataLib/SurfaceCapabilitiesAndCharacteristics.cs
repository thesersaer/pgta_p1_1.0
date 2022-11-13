using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;

namespace FlightDataLib
{
    public class SurfaceCapabilitiesAndCharacteristics
    {
        bool positionIsReferencePointADSB;
        bool cdtiOperational;
        bool b2LowPower; // <70 W if true
        bool receivingAtcServices;
        bool identSwitchActive;
        string[] lengthWidth;

        public SurfaceCapabilitiesAndCharacteristics(DataField dataField)
        {
            Dictionary<int, string[]> lwDict = new Dictionary<int, string[]>();
            string[] uapFile = File.ReadAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/LWac.uap");
            foreach (string uapLine in uapFile)
            {
                string[] uapKV = uapLine.Split(';');
                string[] lwStrArr = { uapKV[1], uapKV[2] };
                lwDict.Add(Convert.ToInt32(uapKV[0]), lwStrArr);
            }

            List<string> content = dataField.getDataField();
            int primaryInt = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber);
            positionIsReferencePointADSB = ((primaryInt >> 5) & 0b1) != 0;
            cdtiOperational = ((primaryInt >> 4) & 0b1) != 0;
            b2LowPower = ((primaryInt >> 3) & 0b1) != 0;
            receivingAtcServices = ((primaryInt >> 2) & 0b1) != 0;
            identSwitchActive = ((primaryInt >> 1) & 0b1) != 0;
            if ((primaryInt & 0b1) != 0) { lengthWidth = lwDict[int.Parse(content[1], System.Globalization.NumberStyles.HexNumber)]; }
        }
        public bool getPositionIsReferencePointADSB() { return positionIsReferencePointADSB; }
        public bool getCdtiOperational() { return cdtiOperational; }
        public bool getB2LowPower() { return b2LowPower; }
        public bool getReceivingAtcServices() { return receivingAtcServices; }
        public bool getIdentSwitchActive() { return identSwitchActive; }
        public string[] getLengthWidth() { return lengthWidth; }
    }
}
