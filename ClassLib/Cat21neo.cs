using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Cat21neo
    {
        //readonly List<bool> fspecList = new List<bool>();
        Queue<int> fspecTrueQueue = new Queue<int>();
        public readonly byte[] contentArray;
        int iiGlobalCounter = 3;
        readonly ushort len;

        #region Constructors
        public Cat21neo() { }
        public Cat21neo(string[] stringArray)
        {
            //Translating hex string array to sbyte array
            contentArray = new byte[stringArray.Length];
            for (int iiByteStr = 0; iiByteStr < stringArray.Length; iiByteStr++)
            {
                contentArray[iiByteStr] = byte.Parse(stringArray[iiByteStr], System.Globalization.NumberStyles.HexNumber);
            }
            this.len = concatToInt16(new byte[2] { contentArray[1],contentArray[2]});

            //Obtaining fspec

            /*
            int iiFspec = 3;
            bool fxBool;
            var fspecTrueQueue = new Queue<int>();
            do
            {
                for (int iiBit = 7; iiBit > 0; iiBit--)
                {
                    bool fspecBool = ((contentList[iiFspec] >> iiBit) & 0b1) == 1;
                    fspecList.Add(fspecBool);
                }
                fxBool = (contentList[iiFspec] & 0b1) == 1;
                iiFspec++;
            } while (fxBool);
            */

            int iiFrn = 1;
            bool fxBool;
            do
            {
                for (int iiBit = 7; iiBit > 0; iiBit--)
                {
                    if (((contentArray[iiGlobalCounter] >> iiBit) & 0b1) != 0)
                    {
                        fspecTrueQueue.Enqueue(iiFrn);
                    }
                    iiFrn++;
                }
                fxBool = (contentArray[iiGlobalCounter] & 0b1) == 1;
                iiGlobalCounter++;
            } while (fxBool);

            // Iterating through data
            while (fspecTrueQueue.Count > 0)
            {
                int frnInt = fspecTrueQueue.Dequeue();
                if (frnInt == 1) { dataSourceIdentification = new DataSourceIdentification(this.contentArray, iiGlobalCounter); }

            }
        }
        #endregion

        #region Data Items
        #region Data Source Identification
        public DataSourceIdentification dataSourceIdentification;
        public class DataSourceIdentification
        {
            public readonly byte sic;
            public readonly byte sac;

            public DataSourceIdentification(byte[] content, int globalCounter)
            {
                this.sac = content[globalCounter];
                this.sic = content[globalCounter + 1];
                globalCounter += 2;
            }
        }
        #endregion
        #endregion

        #region Funciones
        public ushort concatToInt16(byte[] byteArray)
        {
            return (ushort)((byteArray[0] << 8) | byteArray[1]);
        }
        #endregion
    }
}
