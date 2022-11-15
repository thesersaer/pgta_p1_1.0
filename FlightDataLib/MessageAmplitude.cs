using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class MessageAmplitude
    {
        int messageAmplitude;

        public MessageAmplitude(List<string> content)
        {
            this.messageAmplitude = Utilities.compl2(int.Parse(content[0], System.Globalization.NumberStyles.HexNumber));
        }
        public int getMessageAmplitude() { return messageAmplitude; }
    }
}
