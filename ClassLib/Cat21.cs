using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Cat21
    {
        List<DataField> dataFieldList = new List<DataField>();
        uapCat21 uapClass = new uapCat21();
        dataFieldDict dataFieldClass = new dataFieldDict();
        ArrayList decodedDataFieldList = new ArrayList();

        public Cat21(string[] stringArray)
        {
            int iiFspec = 3;
            string fspec = "";
            int fieldExtensionIndicator;
            do
            {
                string fspecBinString = Convert.ToString(Convert.ToInt32(stringArray[iiFspec], 16), 2).PadLeft(8, '0');
                fspecBinString = fspecBinString.Remove(fspecBinString.Length - 1);
                fspec += fspecBinString;
                iiFspec++;
                // FX is calculated at the end of the iteration, no RE nor SP are saved in FSPEC (?)
                fieldExtensionIndicator = int.Parse(stringArray[iiFspec], System.Globalization.NumberStyles.HexNumber) & 1;
            } while (fieldExtensionIndicator == 1);

            int iiDataItem = iiFspec + 1; // First item after FSPEC
            for (int jjOnesIndex = fspec.IndexOf("1"); jjOnesIndex > -1; jjOnesIndex = (fspec.IndexOf("1", jjOnesIndex + 1))) //Through all frn in order
            {
                int iiFrn = jjOnesIndex + 1;
                string dataFieldLength = uapClass.getUapLen(iiFrn);
                List<string> dataContentList = new List<string>();
                string compFspec = "";
                if (int.TryParse(dataFieldLength, out int len))
                {
                    for (int x = 0; x < len; x++)
                    {
                        dataContentList.Add(stringArray[iiDataItem]);
                        iiDataItem++;
                    }
                }
                else if (dataFieldLength == "1p")
                {
                    int dataFieldFX;
                    do
                    {
                        dataFieldFX = int.Parse(stringArray[iiDataItem], System.Globalization.NumberStyles.HexNumber) & 1;
                        dataContentList.Add(stringArray[iiDataItem]);
                        iiDataItem++;
                    } while (dataFieldFX == 1);
                }
                else if (dataFieldLength == "1pc")
                {
                    int dataFieldFX;
                    do
                    {
                        dataFieldFX = int.Parse(stringArray[iiDataItem], System.Globalization.NumberStyles.HexNumber) & 1;
                        //add fspec
                        string dataFieldFspecStr = Convert.ToString(Convert.ToInt32(stringArray[iiDataItem], 16), 2).PadLeft(8, '0');
                        compFspec += dataFieldFspecStr.Remove(dataFieldFspecStr.Length - 1);
                        iiDataItem++;
                    } while (dataFieldFX == 1);
                    for (int x = 0; x < (compFspec.Split('1').Length - 1); x++)
                    {
                        dataContentList.Add(stringArray[iiDataItem]);
                        iiDataItem++;
                    }

                }
                else if (dataFieldLength == "1p8n")
                {
                    int repFactor = int.Parse(stringArray[iiDataItem], System.Globalization.NumberStyles.HexNumber);
                    iiDataItem++;
                    for (int x = 0; x < repFactor; x++)
                    {
                        dataContentList.Add(stringArray[iiDataItem]);
                        iiDataItem++;
                    }
                }
                if (compFspec == "") { dataFieldList.Add(new DataField(iiFrn, dataContentList)); }
                else { dataFieldList.Add(new DataField(iiFrn, compFspec, dataContentList)); }
            }

        }
        public void decodeDataFields()
        {
            foreach (var iiDataField in dataFieldList)
            {
                int dataFieldFrn = iiDataField.getFrn();
                string classNameStr = dataFieldClass.getFrnClassName(dataFieldFrn);
                string getTypeArg = "FlightDataLib." + classNameStr + ", FlightDataLib";
                var createInsArg = Type.GetType(getTypeArg);
                object[] objectParam = new object[1];
                objectParam[0] = iiDataField.getDataField();
                var decodedDataField = Activator.CreateInstance(createInsArg, objectParam);
                decodedDataFieldList.Add(decodedDataField);
            }
        }
    }
}
