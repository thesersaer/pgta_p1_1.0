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
        List<Cat21neo> listCat21 = new List<Cat21neo>();
        List<CatAll> listCatAll = new List<CatAll>();

        DataTable tableCat10 = new DataTable();
        DataTable tableCat21 = new DataTable();
        DataTable tableCatAll = new DataTable();

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

        public List<Cat21neo> getListCat21()
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
        public DataTable getTableCatAll()
        {
            return this.tableCatAll;
        }
        public void tabulateCatAll()
        {
            tableCatAll.Columns.Add("Category", typeof(string));
            tableCatAll.Columns.Add("Position in global list", typeof(int));
            tableCatAll.Columns.Add("Position in own list", typeof(int));
            tableCatAll.Columns.Add("Time (s)", typeof(double));
            tableCatAll.Columns.Add("Latitude", typeof(double));
            tableCatAll.Columns.Add("Longitude", typeof(double));
            tableCatAll.Columns.Add("SIC", typeof(string));
            tableCatAll.Columns.Add("SAC", typeof(string));
            tableCatAll.Columns.Add("Track Number", typeof(string));
            tableCatAll.Columns.Add("Target Address", typeof(string));
            tableCatAll.Columns.Add("Target ID", typeof(string));
            tableCatAll.Columns.Add("Flight Level", typeof(string));
            int i = 0;
            foreach (CatAll iiCatAll in listCatAll)
            {
                tableCatAll.Rows.Add(iiCatAll.CATMode, i, iiCatAll.NumLlista, iiCatAll.TimeofDayseg, iiCatAll.LatWGS84, iiCatAll.LongWGS84, iiCatAll.SIC, iiCatAll.SAC, iiCatAll.TrackNumber, iiCatAll.TargetAddress, iiCatAll.TargetID, iiCatAll.FLXXX);
                i++;
            }
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
                        CatAll newCatAll = new CatAll("SMR", indexSMR,newCat10.TimeOfDaySeg, newCat10.LatWGS84Mapa, newCat10.LongWGS84Mapa, newCat10.SIC, newCat10.SAC, newCat10.TrackNumber, newCat10.TargetAddress, newCat10.TargetID, newCat10.FLXXX);
                        listCatAll.Add(newCatAll);
                        indexSMR = indexSMR + 1;
                    }
                    else if(newCat10.SIC == "107")
                    {
                        listCat10MLAT.Add(newCat10);
                        CatAll newCatAll = new CatAll("MLAT", indexMLAT, newCat10.TimeOfDaySeg, newCat10.LatWGS84Mapa, newCat10.LongWGS84Mapa, newCat10.SIC, newCat10.SAC, newCat10.TrackNumber, newCat10.TargetAddress, newCat10.TargetID, newCat10.FLXXX);
                        listCatAll.Add(newCatAll);
                        indexMLAT = indexMLAT + 1;
                    }
                }
                else if (catInt == 21)
                {
                    Cat21neo newCat21 = new Cat21neo(stringArray);
                    listCat21.Add(newCat21);
                    double catTime;
                    if (newCat21.timeOfAsterixReport != null) { catTime = newCat21.timeOfAsterixReport.torSeconds; } else { catTime = -1;}
                    double catLatitude;
                    double catLongitude;
                    if (newCat21.positionWGS84 != null) 
                    { catLatitude = newCat21.positionWGS84.latitude; catLongitude = newCat21.positionWGS84.longitude; } 
                    else { catLatitude = -1; catLongitude = -1; }
                    string catSic;
                    string catSac;
                    if (newCat21.dataSourceIdentification != null) 
                    { catSic = newCat21.dataSourceIdentification.sic.ToString(); catSac = newCat21.dataSourceIdentification.sac.ToString(); } 
                    else { catSic = "-1"; catSac = "-1"; }
                    string catTrackNumber;
                    if (newCat21.trackNumber != null) { catTrackNumber = newCat21.trackNumber.trackNumber.ToString(); } else { catTrackNumber = "-1"; }
                    string catTargetAddress;
                    if (newCat21.targetAddress != null) { catTargetAddress = newCat21.targetAddress.targetAddress.ToString(); } else { catTargetAddress = "-1"; }
                    string catTargetID;
                    if (newCat21.targetIdentification != null) { catTargetID = newCat21.targetIdentification.targetIdentification; } else { catTargetID = "-1"; }
                    string catFL;
                    if (newCat21.flightLevel != null) { catFL = newCat21.flightLevel.flightLevel.ToString(); } else { catFL = "-1"; }
                    CatAll newCatAll = new CatAll("ADSB", indexADSB, catTime, catLatitude, catLongitude, catSic, catSac, catTrackNumber, catTargetAddress, catTargetID, catFL);
                    listCatAll.Add(newCatAll);
                    indexADSB = indexADSB + 1;
                }
            }
            this.tabulateCatAll();
        }
    }
}
