using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class ModeSMBData
    {
        List<BDSMessage> bdsList = new List<BDSMessage>();

        public ModeSMBData(List<string> content)
        {
            int repFactor = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber);
            int iiOctet = 1;
            for (int x = 0; x < repFactor; x++)
            {
                string mbdStr = "";
                for (int y = 0; y < 7; y++) { mbdStr += content[iiOctet]; iiOctet++; }
                int mbd = int.Parse(mbdStr, System.Globalization.NumberStyles.HexNumber);
                string bdsStr = content[iiOctet];
                int bds1 = (int.Parse(bdsStr, System.Globalization.NumberStyles.HexNumber) >> 4) & 0b1111;
                int bds2 = int.Parse(bdsStr, System.Globalization.NumberStyles.HexNumber) & 0b1111;
                bdsList.Add(new BDSMessage(mbd, bds1, bds2));
            }
        }
        public List<BDSMessage> getBdsList() { return bdsList; }
    }
}
