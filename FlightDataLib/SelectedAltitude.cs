using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class SelectedAltitude
    {
        bool sourceInformationProvided;
        string source;
        int altitude;

        public SelectedAltitude(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            sourceInformationProvided = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1) != 0;
            int sourceInt = ((int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 5) & 0b11);
            if (sourceInt == 0) { source = "unk"; }
            else if (sourceInt == 0b1) { source = "Aircraft Altitude (Holding Altitude)"; }
            else if (sourceInt == 0b10) { source = "MCP/FCU Selected Altitude"; }
            else { source = "FMS Selected Altitude"; }
            string altStr = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) & 0b11111).ToString("X") + content[1];
            altitude = Utilities.compl2(int.Parse(altStr, System.Globalization.NumberStyles.HexNumber)) * 25;
        }
        public bool getSourceInformationProvided() { return sourceInformationProvided; }
        public string getSource() { return source; }
        public int getAltitude() { return altitude; }
    }
}
