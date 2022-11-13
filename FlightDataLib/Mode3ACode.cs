using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class Mode3ACode
    {
        int replyCode; //ALREADY IN DECIMAL BASE

        public Mode3ACode(DataField dataField)
        {
            string codeStr = dataField.getDataField()[0] + dataField.getDataField()[1];
            replyCode = Convert.ToInt32(int.Parse(codeStr, System.Globalization.NumberStyles.HexNumber).ToString(), 8);
        }
        public int getReplyCode() { return replyCode; }
    }
}
