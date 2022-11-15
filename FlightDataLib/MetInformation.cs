using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class MetInformation
    {
        int windSpeed;
        int windDirection;
        double temperature;
        int turbulence;

        public MetInformation(List<string> content, string dataFspec)
        {
            int iiOctet = 1;
            for (int jjOnesIndex = dataFspec.IndexOf("1"); jjOnesIndex > -1; jjOnesIndex = (dataFspec.IndexOf("1", jjOnesIndex + 1)))
            {
                if (jjOnesIndex == 0)
                {
                    windSpeed = int.Parse(content[iiOctet] + content[iiOctet + 1], System.Globalization.NumberStyles.HexNumber);
                    iiOctet += 2;
                }
                if (jjOnesIndex == 1)
                {
                    windDirection = int.Parse(content[iiOctet] + content[iiOctet + 1], System.Globalization.NumberStyles.HexNumber);
                    iiOctet += 2;
                }
                if (jjOnesIndex == 2)
                {
                    temperature = Utilities.compl2(int.Parse(content[iiOctet] + content[iiOctet + 1], System.Globalization.NumberStyles.HexNumber)) * 0.25;
                    iiOctet += 2;
                }
                if (jjOnesIndex == 3)
                {
                    turbulence = int.Parse(content[iiOctet], System.Globalization.NumberStyles.HexNumber);
                }
            }
        }
        public int getWindSpeed() { return windSpeed; }
        public int getWindDirection() { return windDirection; }
        public double getTemperature() { return temperature; }
        public int getTurbulence() { return turbulence; }
    }
}
