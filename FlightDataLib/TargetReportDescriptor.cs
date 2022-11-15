using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightDataLib
{
    public class TargetReportDescriptor
    {
        string addressType;
        string altitudeReportingCapability;
        string rangeCheck;
        string reportType;
        bool diferentialCorrectionADSB;
        bool groundBitSet;
        bool simulatedTarget;
        bool testTarget;
        bool selectedAltitudeAvailable;
        string confidenceLevel;
        bool independentPositionCheckFailed;
        bool nogoBitSet;
        bool compactPositionReportingFailed;
        bool localDecodingPositionJumpDetected;
        bool rangeCheckFailed;

        public TargetReportDescriptor(List<string> content)
        {
            List<string> byteList = content;
            int byteArray = int.Parse(byteList[0], System.Globalization.NumberStyles.HexNumber);
            int atpVal = ((byteArray >> 5) & 0b111);
            if (atpVal > 3)
            { addressType = "reserved"; }
            else if (atpVal > 2)
            { addressType = "anon"; }
            else if (atpVal > 1)
            { addressType = "surfaceVehicle"; }
            else if (atpVal > 0)
            { addressType = "duplicate"; }
            else { addressType = "icao24"; }

            int arcVal = ((byteArray >> 3) & 0b11);
            if (arcVal > 2)
            { altitudeReportingCapability = "invalid"; }
            else if (arcVal > 1)
            { altitudeReportingCapability = "unk"; }
            else if (arcVal > 0)
            { altitudeReportingCapability = "100ft"; }
            else { altitudeReportingCapability = "25ft"; }

            int rcVal = ((byteArray >> 2) & 0b1);
            if (rcVal > 0) { rangeCheck = "default"; }
            else { rangeCheck = "passed"; }

            int rabVal = ((byteArray >> 1) & 0b1);
            if (rabVal > 0) { reportType = "monitor"; }
            else { reportType = "target"; }

            if ((byteArray & 0b1) != 0) //FIRST EXT
            {
                byteArray = int.Parse(byteList[1], System.Globalization.NumberStyles.HexNumber);

                diferentialCorrectionADSB = ((byteArray >> 7) & 0b1) != 0;
                groundBitSet = ((byteArray >> 6) & 0b1) != 0;
                simulatedTarget = ((byteArray >> 5) & 0b1) != 0;
                testTarget = ((byteArray >> 4) & 0b1) != 0;
                selectedAltitudeAvailable = ((byteArray >> 3) & 0b1) != 0;
                int clVal = ((byteArray >> 1) & 0b11);
                if (clVal > 2) { confidenceLevel = "reserved"; }
                else if (clVal > 1) { confidenceLevel = "noinf"; }
                else if (clVal > 0) { confidenceLevel = "suspect"; }
                else { confidenceLevel = "valid"; }

                if ((byteArray & 0b1) != 0) //SECOND EXT
                {
                    byteArray = int.Parse(byteList[2], System.Globalization.NumberStyles.HexNumber);

                    independentPositionCheckFailed = ((byteArray >> 5) & 0b1) != 0;
                    nogoBitSet = ((byteArray >> 4) & 0b1) != 0;
                    compactPositionReportingFailed = ((byteArray >> 3) & 0b1) != 0;
                    localDecodingPositionJumpDetected = ((byteArray >> 2) & 0b1) != 0;
                    rangeCheckFailed = ((byteArray >> 1) & 0b1) != 0;
                }
            }

        }
        public string getAddressType() { return addressType; }
        public string getAltitudeReportingCapability() { return altitudeReportingCapability; }
        public string getRangeCheck() { return rangeCheck; }
        public string getReportType() { return reportType; }
        public bool getDiferentialCorrectionADSB() { return diferentialCorrectionADSB; }
        public bool getGroundBitSet() { return groundBitSet; }
        public bool getSimulatedTarget() { return simulatedTarget; }
        public bool getTestTarget() { return testTarget; }
        public bool getSelectedAltitudeAvailable() { return selectedAltitudeAvailable; }
        public string getConfidenceLevel() { return confidenceLevel; }
        public bool getIndependentPositionCheckFailed() { return independentPositionCheckFailed; }
        public bool getNogoBitSet() { return nogoBitSet; }
        public bool getCompactPositionReportingFailed() { return compactPositionReportingFailed; }
        public bool getLocalDecodingPositionJumpDetected() { return localDecodingPositionJumpDetected; }
        public bool getRangeCheckFailed() { return rangeCheckFailed; }
    }
}
