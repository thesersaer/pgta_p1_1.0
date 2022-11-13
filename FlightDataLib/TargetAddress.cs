using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class TargetAddress
    {
        int address;

        public TargetAddress(DataField dataField)
        {
            string addressStr = dataField.getDataField()[0] + dataField.getDataField()[1] + dataField.getDataField()[2];
            address = int.Parse(addressStr, System.Globalization.NumberStyles.HexNumber);
        }
        public int getAddress() { return address; }
    }
}
