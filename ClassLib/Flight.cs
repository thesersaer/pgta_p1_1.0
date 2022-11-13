using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Flight
    {
        public string Callsign;
        public string ICAOAdress;
        public string TrackNumber;
        public string MOPSversion;
        public List<string> VectorTiempo = new List<string>();
        public List<string> LatitudeInWGS84 = new List<string>();
        public List<string> LongitudeInWGS84 = new List<string>();
        public string puntos;
        public List<string> FL = new List<string>();
        public List<string> groundSpeed = new List<string>();
        public string HAccuracy;
        public string VAccuracy;
        public string Pd;

        public void fillCAT10flight(Cat10 cat10)
        {
            this.Callsign = cat10.TargetID;
            this.ICAOAdress = cat10.TargetAddress;
            this.TrackNumber = cat10.TrackNumber;
            this.MOPSversion = "Category 10";
            VectorTiempo.Add(cat10.TimeOfDay);
            LatitudeInWGS84.Add(cat10.LatitudeInWGS84);
            LongitudeInWGS84.Add(cat10.LongitudeInWGS84);

            FL.Add(cat10.FLXXX);
            groundSpeed.Add(cat10.GroundSpeedInPolar);



        }


        public void addValueCAT10Flight(Cat10 cat10)
        {
            if (this.Callsign == null && cat10.TargetID != null)
            {
                this.Callsign = cat10.TargetID;
            }
            VectorTiempo.Add(cat10.TimeOfDay);
            LatitudeInWGS84.Add(cat10.LatitudeInWGS84);
            LongitudeInWGS84.Add(cat10.LongitudeInWGS84);
            FL.Add(cat10.FLXXX);
            groundSpeed.Add(cat10.GroundSpeedInPolar);
        }

    }
}
