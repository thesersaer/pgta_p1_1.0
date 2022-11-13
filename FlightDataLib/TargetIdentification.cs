using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;

namespace FlightDataLib
{
    public class TargetIdentification
    {
        string targetIdentification;

        public TargetIdentification(DataField dataField)
        {
            List<string> content = dataField.getDataField();

            Dictionary<int, string> tiDict = new Dictionary<int, string>();

            using (StreamReader sr = new StreamReader(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/TargetIdentification.uap"))
            {
                string _line;
                while ((_line = sr.ReadLine()) != null)
                {
                    string[] keyvalue = _line.Split('=');
                    if (keyvalue.Length == 2)
                    {
                        tiDict.Add(int.Parse(keyvalue[0]), keyvalue[1]);
                    }
                }
            }

            string tiStr = "";
            for (int iiOctet = 0; iiOctet < content.Count; iiOctet++) { tiStr += content[iiOctet]; }
            int tiInt = int.Parse(tiStr, System.Globalization.NumberStyles.HexNumber);
            string tiDecodedStr = "";
            for (int iiChar = 0; iiChar < 8; iiChar++)
            {
                int characterInt = tiInt >> (42 - 6 * iiChar) & 0b111111;
                tiDecodedStr += tiDict[characterInt];
            }
            targetIdentification = tiDecodedStr;
        }
        public string getTargetIdentification() { return targetIdentification; }
    }
}
