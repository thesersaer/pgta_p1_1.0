using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class CatAll
    {
        public int NumLlista;
        public string CATMode;
        public double TimeofDayseg;
        public double LatWGS84;
        public double LongWGS84;
        public string SAC;
        public string SIC;
        public string TrackNumber;
        public string TargetAddress;
        public string TargetID;
        public string FLXXX;


        public CatAll(string CATM, int i, double Time, double Lat, double Long, string SIC, string SAC, string TNum, string targetAd, string TarID, string FL)
        {
            this.CATMode = CATM;
            this.NumLlista = i;
            this.TimeofDayseg = Time;
            this.LatWGS84 = Lat;
            this.LongWGS84 = Long;
            this.SAC = SAC;
            this.SIC = SIC;
            this.TrackNumber = TNum;
            this.TargetAddress = targetAd;
            this.TargetID = TarID;
            this.FLXXX = FL;
        }
    }
}
