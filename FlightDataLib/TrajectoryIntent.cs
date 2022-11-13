using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;

namespace FlightDataLib
{
    public class TrajectoryIntent
    {
        bool trajectoryIntentDataAvailable;
        bool trajectoryIntentDataValid;
        List<TrajectoryIntentPoint> pointList = new List<TrajectoryIntentPoint>();


        public TrajectoryIntent(DataField dataField)
        {
            List<string> octetList = dataField.getDataField();

            int firstOct = int.Parse(octetList[0], System.Globalization.NumberStyles.HexNumber);
            bool tisPresent = ((firstOct >> 7) & 0b1) != 0;
            bool tidPresent = ((firstOct >> 6) & 0b1) != 0;
            int iiOctet = 1;

            if (tisPresent)
            {
                int subf1 = int.Parse(octetList[iiOctet], System.Globalization.NumberStyles.HexNumber);
                trajectoryIntentDataAvailable = ((subf1 >> 7) & 0b1) != 0;
                trajectoryIntentDataValid = ((subf1 >> 6) & 0b1) != 0;
                iiOctet++;
            }

            if (tidPresent)
            {
                int fieldRepetitionIndicator = int.Parse(octetList[iiOctet], System.Globalization.NumberStyles.HexNumber);
                iiOctet++;
                for (int iiTip = 0; iiTip < fieldRepetitionIndicator; iiTip++)
                {
                    List<string> singlePointList = new List<string>();
                    for (int x = 0; x < 15; x++)
                    {
                        singlePointList.Add(octetList[iiOctet]);
                        iiOctet++;
                    }
                    pointList.Add(new TrajectoryIntentPoint(singlePointList));
                }
            }
        }
        public bool getTrajectoryIntentDataAvailable() { return trajectoryIntentDataAvailable; }
        public bool getTrajectoryIntentDataValid() { return trajectoryIntentDataValid; }
        public List<TrajectoryIntentPoint> getPointList() { return pointList; }
    }
}
