using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class BDSMessage
    {
        int mbData;
        int commBDS1Address;
        int commBDS2Address;

        public BDSMessage(int mbd, int bds1, int bds2)
        {
            mbData = mbd;
            commBDS1Address = bds1;
            commBDS2Address = bds2;
        }
        public int getMBData() { return mbData; }
        public int getCommBDS1Address() { return commBDS1Address; }
        public int getCommBDS2Address() { return commBDS2Address; }
    }
}
