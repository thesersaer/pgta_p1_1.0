using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class TrackNumber
    {
        int trackNumber;

        public TrackNumber(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            trackNumber = int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber);
        }
        public int getTrackNumber() { return trackNumber; }
    }
}
