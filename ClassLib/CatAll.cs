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
        
        public CatAll(string CATM, int i, double Time, double Lat, double Long)
        {
            this.CATMode = CATM;
            this.NumLlista = i;
            this.TimeofDayseg = Time;
            this.LatWGS84 = Lat;
            this.LongWGS84 = Long;
        }
    }
}
