using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class TargetAddress
    {
        int address;

        public TargetAddress(List<string> content)
        {
            string addressStr = content[0] + content[1] + content[2];
            address = int.Parse(addressStr, System.Globalization.NumberStyles.HexNumber);
        }
        public int getAddress() { return address; }
    }
}
