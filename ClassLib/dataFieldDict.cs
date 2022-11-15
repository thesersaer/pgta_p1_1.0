using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLib
{
    public class dataFieldDict
    {
        Dictionary<int, string> frnDict = new Dictionary<int, string>();

        public dataFieldDict()
        {
            string[] uapFile = File.ReadAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/ClassLib/dataFieldFrn.uap");
            foreach (string uapLine in uapFile)
            {
                string[] uapKV = uapLine.Split('=');
                frnDict.Add(Convert.ToInt32(uapKV[0]), uapKV[1]);
            }
        }
        public string getFrnClassName(int frn) { return frnDict[frn]; }
    }
}
