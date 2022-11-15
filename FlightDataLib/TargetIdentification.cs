using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightDataLib
{
    public class TargetIdentification
    {
        string targetIdentification;

        public TargetIdentification(List<string> content)
        {
            Dictionary<int, string> tiDict = new Dictionary<int, string>();

            using (StreamReader sr = new StreamReader(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/FlightDataLib/TargetIdentification.uap"))
            {
                string _line;
                while ((_line = sr.ReadLine()) != null)
                {
                    string[] keyvalue = _line.Split('=');
                    if (keyvalue.Length == 2)
                    {
                        tiDict.Add(Convert.ToInt32(keyvalue[0], 2), keyvalue[1]);
                    }
                }
            }

            string tiStr = "";
            string tiDecodedStr = "";
            for (int iiOctet = 0; iiOctet < content.Count; iiOctet++) 
            { 
                tiStr += Convert.ToString(int.Parse(content[iiOctet],System.Globalization.NumberStyles.HexNumber),2).PadLeft(8, '0');
            }
            for (int iiStr = 0; iiStr < tiStr.Length; iiStr += 6)
            {
                string charStr = tiStr.Substring(tiStr.Length - iiStr - 6, 6);
                int charInt = Convert.ToInt32(charStr, 2);
                tiDecodedStr = tiDict[charInt] + tiDecodedStr;                
            }
            targetIdentification = tiDecodedStr;
        }
        public string getTargetIdentification() { return targetIdentification; }
    }
}
