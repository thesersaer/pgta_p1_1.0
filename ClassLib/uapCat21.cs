using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class uapCat21
    {
        Dictionary<Int32, string> uapDict = new Dictionary<Int32, string>();

        public uapCat21()
        {
            string[] uapFile = File.ReadAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/ClassLib/cat21.uap");
            foreach (string uapLine in uapFile)
            {
                string[] uapKV = uapLine.Split(';');
                uapDict.Add(Convert.ToInt32(uapKV[0]), uapKV[1]);
            }
        }

        public string getUapLen(int frn)
        {
            return uapDict[frn];
        }
    }
}
