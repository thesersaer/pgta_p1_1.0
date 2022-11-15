using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class ReceiverId
    {
        int receiverId;

        public ReceiverId(List<string> content)
        {
            receiverId = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber);
        }
        public int getReceiverId() { return receiverId; }
    }
}
