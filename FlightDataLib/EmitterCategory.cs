using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightDataLib
{
    public class EmitterCategory
    {
        string emitterCategory;

        public EmitterCategory(List<string> content)
        {
            Dictionary<int, string> categoryDict = new Dictionary<int, string>();
            string[] uapFile = File.ReadAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/FlightDataLib/EmitterCategory.uap");
            foreach (string uapLine in uapFile)
            {
                string[] uapKV = uapLine.Split(';');
                categoryDict.Add(Convert.ToInt32(uapKV[0]), uapKV[1]);
            }
            int catKey = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber);
            emitterCategory = categoryDict[catKey];
        }
        public string getEmitterCategory() { return emitterCategory; }
    }
}
