using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class PositionWGS84HP
    {
        double latitude;
        double longitude;

        public PositionWGS84HP(DataField dataField)
        {
            double resolutionFactor = (180 / Math.Pow(2, 30));
            List<string> dataList = dataField.getDataField();
            string latStr = dataList[0] + dataList[1] + dataList[2] + dataList[3];
            this.latitude = Utilities.compl2(int.Parse(latStr, System.Globalization.NumberStyles.HexNumber)) * resolutionFactor;
            string longStr = dataList[4] + dataList[5] + dataList[6] + dataList[7];
            this.longitude = Utilities.compl2(int.Parse(longStr, System.Globalization.NumberStyles.HexNumber)) * resolutionFactor;
        }
        public double getLatitude() { return latitude; }
        public double getLongitude() { return longitude; }
    }
}
