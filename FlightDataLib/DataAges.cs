using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;

namespace FlightDataLib
{
    public class DataAges
    {
        List<DataAgeItem> ageItems = new List<DataAgeItem>();

        public DataAges(DataField dataField)
        {
            Dictionary<int, string> daDict = new Dictionary<int, string>();
            string[] uapFile = File.ReadAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/DataAgeItem.uap");
            foreach (string uapLine in uapFile)
            {
                string[] uapKV = uapLine.Split(';');
                daDict.Add(Convert.ToInt32(uapKV[0]), uapKV[1]);
            }

            List<string> content = dataField.getDataField();
            string fspecStr = "";
            int iiOctet = 0;
            int fxInt;
            do
            {
                string octStr = content[iiOctet];
                fspecStr += Convert.ToString(Convert.ToInt32(octStr, 16), 2).PadLeft(8, '0');
                fxInt = int.Parse(octStr, System.Globalization.NumberStyles.HexNumber) & 0b1;
                iiOctet++;
            } while (fxInt == 1);

            for (int jjOnesIndex = fspecStr.IndexOf("1"); jjOnesIndex > -1; jjOnesIndex = (fspecStr.IndexOf("1", jjOnesIndex + 1)))
            {
                ageItems.Add(new DataAgeItem(content[iiOctet], daDict[jjOnesIndex]));
                iiOctet++;
            }
        }
        public List<DataAgeItem> getAgeItems() { return ageItems; }
    }
}
