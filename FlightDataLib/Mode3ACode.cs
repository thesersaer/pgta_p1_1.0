using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class Mode3ACode
    {
        string replyCode; //ALREADY IN DECIMAL BASE

        public Mode3ACode(List<string> content)
        {
            string codeStr = content[0] + content[1];
            string oct = Convert.ToString(Convert.ToInt32(codeStr, 16), 2).PadLeft(16, '0');
            int n = 4;
            while (n < oct.Length)
            {
                this.replyCode = this.replyCode + Convert.ToString(Convert.ToInt32(oct.Substring(n, 3), 2));
                n = n + 3;
            }
        }
        public string getReplyCode() { return replyCode; }
    }
}
