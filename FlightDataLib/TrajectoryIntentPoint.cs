using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.IO;

namespace FlightDataLib
{
    public class TrajectoryIntentPoint
    {
        bool tcpNumberAvailable;
        bool tcpNonCompliance;
        int tcpNumber;
        int altitude;
        double latitude;
        double longitude;
        string pointType;
        string turnDirection;
        bool turnRadiusAvailable;
        bool tovNotAvailable;
        int timeOverPoint;
        double tcpTurnRadius;

        public TrajectoryIntentPoint(List<string> tidList)
        {
            this.tcpNumberAvailable = ((int.Parse(tidList[0], System.Globalization.NumberStyles.HexNumber) >> 7) & 0b1) != 0;
            this.tcpNonCompliance = ((int.Parse(tidList[0], System.Globalization.NumberStyles.HexNumber) >> 6) & 0b1) != 0;
            this.tcpNumber = int.Parse(tidList[0], System.Globalization.NumberStyles.HexNumber) & 0b111111;
            string altStr = tidList[1] + tidList[2];
            this.altitude = Utilities.compl2(int.Parse(altStr, System.Globalization.NumberStyles.HexNumber)) * 10;
            string latStr = tidList[3] + tidList[4] + tidList[5];
            this.latitude = Utilities.compl2(int.Parse(latStr, System.Globalization.NumberStyles.HexNumber)) * (180 / Math.Pow(2, 23));
            string longStr = tidList[6] + tidList[7] + tidList[8];
            this.longitude = Utilities.compl2(int.Parse(longStr, System.Globalization.NumberStyles.HexNumber)) * (180 / Math.Pow(2, 23));

            Dictionary<int, string> ptDict = new Dictionary<int, string>();
            string[] uapFile = File.ReadAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/TrajectoryIntentPoint.uap");
            foreach (string uapLine in uapFile)
            {
                string[] uapKV = uapLine.Split(';');
                ptDict.Add(Convert.ToInt32(uapKV[0]), uapKV[1]);
            }

            this.pointType = ptDict[((int.Parse(tidList[9], System.Globalization.NumberStyles.HexNumber) >> 4) & 0b1111)];
            int turnDirectionInt = ((int.Parse(tidList[9], System.Globalization.NumberStyles.HexNumber) >> 2) & 0b11);
            if (turnDirectionInt == 0b0) { this.turnDirection = "N/A"; }
            else if (turnDirectionInt == 0b1) { this.turnDirection = "Turn right"; }
            else if (turnDirectionInt == 0b10) { this.turnDirection = "Turn left"; }
            else { this.turnDirection = "No turn"; }
            this.turnRadiusAvailable = ((int.Parse(tidList[9], System.Globalization.NumberStyles.HexNumber) >> 1) & 0b1) != 0;
            this.tovNotAvailable = (int.Parse(tidList[9], System.Globalization.NumberStyles.HexNumber) & 0b1) != 0;
            string tovStr = tidList[10] + tidList[11] + tidList[12];
            this.timeOverPoint = int.Parse(tovStr, System.Globalization.NumberStyles.HexNumber);
            string ttrStr = tidList[13] + tidList[14];
            this.tcpTurnRadius = int.Parse(ttrStr, System.Globalization.NumberStyles.HexNumber) * 0.01;
        }
        public bool getTcpNumberAvailable() { return tcpNumberAvailable; }
        public bool getTcpNonCompliance() { return tcpNonCompliance; }
        public int getTcpNumber() { return tcpNumber; }
        public int getAltitude() { return altitude; }
        public double getLatitude() { return latitude; }
        public double getLongitude() { return longitude; }
        public string getPointType() { return pointType; }
        public string getTurnDirection() { return turnDirection; }
        public bool getTurnRadiusAvailable() { return turnRadiusAvailable; }
        public bool getTovNotAvailable() { return tovNotAvailable; }
        public int getTimeOverPoint() { return timeOverPoint; }
        public double getTcpTurnRadius() { return tcpTurnRadius; }
    }
}
