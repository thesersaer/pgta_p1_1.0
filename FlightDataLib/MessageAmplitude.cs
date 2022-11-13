using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class MessageAmplitude
    {
        int messageAmplitude;

        public MessageAmplitude(DataField dataField)
        {
            this.messageAmplitude = Utilities.compl2(int.Parse(dataField.getDataField()[0], System.Globalization.NumberStyles.HexNumber));
        }
        public int getMessageAmplitude() { return messageAmplitude; }
    }
}
