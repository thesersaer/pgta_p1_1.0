using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightDataLib
{
    public class DataAges
    {
        List<DataAgeItem> ageItems = new List<DataAgeItem>();

        public DataAges(List<string> content)
        {
            Dictionary<int, string> daDict = new Dictionary<int, string>();
            string[] uapFile = File.ReadAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/FlightDataLib/DataAgeItem.uap");
            foreach (string uapLine in uapFile)
            {
                string[] uapKV = uapLine.Split('=');
                daDict.Add(Convert.ToInt32(uapKV[0]), uapKV[1]);
            }

            string fspecStr = "";
            int iiOctet = 0;
            int fxInt;
            do
            {
                string octStr = content[iiOctet];
                fspecStr = fspecStr + Convert.ToString(int.Parse(octStr,System.Globalization.NumberStyles.HexNumber), 2).PadLeft(8, '0');
                fxInt = int.Parse(octStr, System.Globalization.NumberStyles.HexNumber) & 0b1;
                iiOctet++;
            } while (fxInt == 1);

            int[] fxIntArr = { 0, 8, 16, 24 };
            for (int jjOnesIndex = fspecStr.IndexOf("1"); jjOnesIndex > -1; jjOnesIndex = (fspecStr.IndexOf("1", jjOnesIndex + 1)))
            {
                if (!fxIntArr.Contains(31 - jjOnesIndex))
                {
                    try
                    {
                        ageItems.Add(new DataAgeItem(content[iiOctet], daDict[31 - jjOnesIndex]));
                    } catch (System.Collections.Generic.KeyNotFoundException) { }
                    iiOctet++;
                }
            }
        }
        public List<DataAgeItem> getAgeItems() { return ageItems; }
    }
}
