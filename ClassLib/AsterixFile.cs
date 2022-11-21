using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace ClassLib
{
    public class AsterixFile
    {
        string filepath;
        List<Cat10> listCat10SMR = new List<Cat10>();
        List<Cat10> listCat10MLAT = new List<Cat10>();
        List<Cat21> listCat21 = new List<Cat21>();
        List<CatAll> listCatAll = new List<CatAll>();

        DataTable tableCat10 = new DataTable();
        DataTable tableCat21 = new DataTable();

        public void setFilepath(string path)
        {
            this.filepath = path;
        }

        public List<Cat10> getListCat10SMR()
        {
            return this.listCat10SMR;
        }
        public List<Cat10> getListCat10MLAT()
        {
            return this.listCat10MLAT;
        }

        public List<Cat21> getListCat21()
        {
            return this.listCat21;
        }

        public List<CatAll> getListCatAll()
        {
            return this.listCatAll;
        }

        public DataTable getTableCat10()
        {
            return this.tableCat10;
        }

        public DataTable getTableCat21()
        {
            return this.tableCat21;
        }

        public void readFile()
        {
            byte[] rawFile = File.ReadAllBytes(this.filepath);
            List<byte[]> byteList = new List<byte[]>();
            int rawCounter = 0;
            int recordLength = rawFile[2] + rawFile[1] * 256; //Length of the record specified by the LEN indicator
            while (rawCounter < rawFile.Length)
            {
                byte[] recordArray = new byte[recordLength];
                for (int recordCounter = 0; recordCounter < recordLength; recordCounter++)
                {
                    //Each record is stored in recordArray
                    recordArray[recordCounter] = rawFile[rawCounter];
                    rawCounter++;
                }
                byteList.Add(recordArray);

                if (rawCounter + 2 < rawFile.Length)
                {
                    //Next record's LEN
                    recordLength = rawFile[rawCounter + 2] + rawFile[rawCounter + 1] * 256;
                }

            }

            List<string[]> hexList = new List<string[]>();
            for (int byteListCounter = 0; byteListCounter < byteList.Count; byteListCounter++)
            {
                //List converted from byte to hex
                byte[] recordByteArray = byteList[byteListCounter];
                string[] recordHexArray = new string[recordByteArray.Length];
                for (int recordCounter = 0; recordCounter < recordByteArray.Length; recordCounter++)
                {
                    recordHexArray[recordCounter] = recordByteArray[recordCounter].ToString("X"); // Hex string format
                }
                hexList.Add(recordHexArray);
            }

            int indexSMR = 0;
            int indexMLAT = 0;
            int indexADSB = 0;

            for (int q = 0; q < hexList.Count; q++)
            {
                string[] stringArray = hexList[q];
                int catInt = int.Parse(stringArray[0], System.Globalization.NumberStyles.HexNumber);

                if (catInt == 10)
                {
                    Cat10 newCat10 = new Cat10(stringArray);
                    if(newCat10.SIC == "7")
                    {
                        listCat10SMR.Add(newCat10);
                        CatAll newCatAll = new CatAll("SMR", indexSMR,newCat10.TimeOfDaySeg, newCat10.LatWGS84Mapa, newCat10.LongWGS84Mapa);
                        listCatAll.Add(newCatAll);
                        indexSMR = indexSMR + 1;
                    }
                    else if(newCat10.SIC == "107")
                    {
                        listCat10MLAT.Add(newCat10);
                        CatAll newCatAll = new CatAll("MLAT", indexMLAT, newCat10.TimeOfDaySeg, newCat10.LatWGS84Mapa, newCat10.LongWGS84Mapa);
                        listCatAll.Add(newCatAll);
                        indexMLAT = indexMLAT + 1;
                    }
                }
                else if (catInt == 21)
                {
                    Cat21neo newCat21 = new Cat21neo(stringArray);
                    //listCat21.Add(newCat21);
                    //CatAll newCatAll = new CatAll("ADSB", indexADSB, newCat21.TimeOfDaySeg, newCat10.LatWGS84Mapa, newCat10.LongWGS84Mapa);
                    //listCatAll.Add(newCatAll);
                    indexADSB = indexADSB + 1;
                }
            }

        }
    }
}
