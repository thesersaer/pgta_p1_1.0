using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class MetInformation
    {
        int windSpeed;
        int windDirection;
        double temperature;
        int turbulence;

        public MetInformation(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            int psInt = (int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) >> 4) & 0b1111;
            int iiOctet = 1;
            if (((psInt >> 3) & 0b1) != 0)
            {
                windSpeed = int.Parse(content[iiOctet] + content[iiOctet + 1], System.Globalization.NumberStyles.HexNumber);
                iiOctet += 2;
            }
            if (((psInt >> 2) & 0b1) != 0)
            {
                windDirection = int.Parse(content[iiOctet] + content[iiOctet + 1], System.Globalization.NumberStyles.HexNumber);
                iiOctet += 2;
            }
            if (((psInt >> 1) & 0b1) != 0)
            {
                temperature = Utilities.compl2(int.Parse(content[iiOctet] + content[iiOctet + 1], System.Globalization.NumberStyles.HexNumber)) * 0.25;
                iiOctet += 2;
            }
            if ((psInt & 0b1) != 0)
            {
                turbulence = int.Parse(content[iiOctet], System.Globalization.NumberStyles.HexNumber);
            }
        }
        public int getWindSpeed() { return windSpeed; }
        public int getWindDirection() { return windDirection; }
        public double getTemperature() { return temperature; }
        public int getTurbulence() { return turbulence; }
    }
}
