using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class Mode3ACode
    {
        int replyCode; //ALREADY IN DECIMAL BASE

        public Mode3ACode(List<string> content)
        {
            string codeStr = content[0] + content[1];
            replyCode = Convert.ToInt32(codeStr);
        }
        public int getReplyCode() { return replyCode; }
    }
}
