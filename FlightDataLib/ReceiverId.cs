using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLib;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class ReceiverId
    {
        int receiverId;

        public ReceiverId(DataField dataField)
        {
            receiverId = int.Parse(dataField.getDataField()[0], System.Globalization.NumberStyles.HexNumber);
        }
        public int getReceiverId() { return receiverId; }
    }
}
