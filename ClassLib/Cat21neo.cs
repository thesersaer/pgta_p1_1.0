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
        static int iiGlobalCounter = 3;
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
                if (frnInt == 1) { dataSourceIdentification = new DataSourceIdentification(contentArray, iiGlobalCounter); }
                else if (frnInt == 2) { targetReportDescriptor = new TargetReportDescriptor(contentArray, iiGlobalCounter); }
                else if (frnInt == 3) { trackNumber = new TrackNumber(contentArray, iiGlobalCounter); }
                else if (frnInt == 4) { serviceIdentification = new ServiceIdentification(contentArray, iiGlobalCounter); }
                else if (frnInt == 5) { timeOfApplicabilityPosition = new TimeOfApplicabilityPosition(contentArray, iiGlobalCounter); }
                else if (frnInt == 6) { positionWGS84 = new PositionWGS84(contentArray, iiGlobalCounter); }
                else if (frnInt == 7) { positionWGS84HP = new PositionWGS84HP(contentArray, iiGlobalCounter); }
                else if (frnInt == 8) { timeOfApplicabilityVelocity = new TimeOfApplicabilityVelocity(contentArray, iiGlobalCounter); }
                else if (frnInt == 9) { airSpeed = new AirSpeed(contentArray, iiGlobalCounter); }
                else if (frnInt == 10) { }

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
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Target Report Descriptor
        public TargetReportDescriptor targetReportDescriptor;
        public class TargetReportDescriptor
        {
            public readonly string addressType;
            public readonly string altitudeReportingCapability;
            public readonly string rangeCheck;
            public readonly string reportType;
            public readonly bool diferentialCorrectionADSB;
            public readonly bool groundBitSet;
            public readonly bool simulatedTarget;
            public readonly bool testTarget;
            public readonly bool selectedAltitudeAvailable;
            public readonly string confidenceLevel;
            public readonly bool independentPositionCheckFailed;
            public readonly bool nogoBitSet;
            public readonly bool compactPositionReportingValidationFailed;
            public readonly bool localDecodingPositionJumpDetected;
            public readonly bool rangeCheckFailed;
            public TargetReportDescriptor(byte[] content, int globalCounter)
            {
                var addressTypeVal = ((content[globalCounter] >> 5) & 0b111);
                if (addressTypeVal == 0) { this.addressType = "24-Bit ICAO address"; }
                else if (addressTypeVal == 1) { this.addressType = "Duplicate address"; }
                else if (addressTypeVal == 2) { this.addressType = "Surface vehicle address"; }
                else if (addressTypeVal == 3) { this.addressType = "Anonymous address"; }
                else  { this.addressType = "Reserved for future use"; }

                var arcVal = ((content[globalCounter] >> 3) & 0b11);
                if (arcVal == 0) { this.altitudeReportingCapability = "25 ft"; }
                else if (arcVal == 1) { this.altitudeReportingCapability = "100 ft"; }
                else if (arcVal == 2) { this.altitudeReportingCapability = "Unknown"; }
                else { this.altitudeReportingCapability = "Invalid"; }

                if (((content[globalCounter] >> 2) & 0b1) == 0) { this.rangeCheck = "Default"; }
                else { this.rangeCheck = "Range Check passed, CPR Validation pending"; }

                if (((content[globalCounter] >> 1) & 0b1) == 0) { this.reportType = "Report from target transponder"; }
                else { this.reportType = "Report from field monitor (fixed transponder) "; }

                if ((content[globalCounter] & 0b1) == 1) //First extension
                {
                    globalCounter++;
                    this.diferentialCorrectionADSB = ((content[globalCounter] >> 7) & 0b1) == 1;
                    this.groundBitSet = ((content[globalCounter] >> 6) & 0b1) == 1;
                    this.simulatedTarget = ((content[globalCounter] >> 5) & 0b1) == 1;
                    this.testTarget = ((content[globalCounter] >> 4) & 0b1) == 1;
                    this.selectedAltitudeAvailable = ((content[globalCounter] >> 3) & 0b1) == 1;
                    var clVar = (content[globalCounter] >> 1) & 0b11;
                    if (clVar == 0) { this.confidenceLevel = "Report valid"; }
                    else if (clVar == 1) { this.confidenceLevel = "Report suspect"; }
                    else if (clVar == 2) { this.confidenceLevel = "No information"; }
                    else { this.confidenceLevel = "Reserved for future use"; }
                    if ((content[globalCounter] & 0b1) == 1) //Second extension
                    {
                        globalCounter++;
                        this.independentPositionCheckFailed = ((content[globalCounter] >> 5) & 0b1) == 1;
                        this.nogoBitSet = ((content[globalCounter] >> 4) & 0b1) == 1;
                        this.compactPositionReportingValidationFailed = ((content[globalCounter] >> 3) & 0b1) == 1;
                        this.localDecodingPositionJumpDetected = ((content[globalCounter] >> 2) & 0b1) == 1;
                        this.rangeCheckFailed = ((content[globalCounter] >> 1) & 0b1) == 1;
                    }
                }
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Track Number
        public TrackNumber trackNumber;
        public class TrackNumber
        {
            public readonly ushort trackNumber;
            public TrackNumber(byte[] content, int globalCounter)
            {
                this.trackNumber = concatToInt16(new byte[] { content[globalCounter], content[globalCounter + 1] });
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Service Identification
        public ServiceIdentification serviceIdentification;
        public class ServiceIdentification
        {
            public readonly byte serviceIdentification;
            public ServiceIdentification(byte[] content, int globalCounter)
            {
                this.serviceIdentification = content[globalCounter];
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Time of Applicability for Position
        public TimeOfApplicabilityPosition timeOfApplicabilityPosition;
        public class TimeOfApplicabilityPosition
        {
            public readonly double toaSeconds;
            public TimeOfApplicabilityPosition(byte[] content, int globalCounter)
            {
                this.toaSeconds = concatToInt32(new byte[3] { content[globalCounter], content[globalCounter + 1], content[globalCounter + 2] })*Math.Pow(2,-7);
                globalCounter += 3;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Position in WGS-84 Co-ordinates
        public PositionWGS84 positionWGS84;
        public class PositionWGS84
        {
            public readonly double latitude;
            public readonly double longitude;
            public PositionWGS84(byte[] content, int globalCounter)
            {
                double resFact = 180 / (Math.Pow(2, 23));
                this.latitude = compl2(concatToInt32(new byte[3] { content[globalCounter], content[globalCounter + 1], content[globalCounter + 2] })) * resFact;
                globalCounter += 3;
                this.longitude = compl2(concatToInt32(new byte[3] { content[globalCounter], content[globalCounter + 1], content[globalCounter + 2] })) * resFact;
                globalCounter += 3;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region High-Resolution Position in WGS-84 Co-ordinates
        public PositionWGS84HP positionWGS84HP;
        public class PositionWGS84HP
        {
            public readonly double latitude;
            public readonly double longitude;
            public PositionWGS84HP(byte[] content, int globalCounter)
            {
                double resFact = 180 / (Math.Pow(2, 30));
                this.latitude = compl2(concatToInt32(new byte[4] { content[globalCounter], content[globalCounter + 1], content[globalCounter + 2], content[globalCounter + 3] })) * resFact;
                globalCounter += 4;
                this.longitude = compl2(concatToInt32(new byte[4] { content[globalCounter], content[globalCounter + 1], content[globalCounter + 2], content[globalCounter + 3] })) * resFact;
                globalCounter += 4;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Time of Applicability for Velocity
        public TimeOfApplicabilityVelocity timeOfApplicabilityVelocity;
        public class TimeOfApplicabilityVelocity
        {
            public readonly double toaSeconds;
            public TimeOfApplicabilityVelocity(byte[] content, int globalCounter)
            {
                this.toaSeconds = concatToInt32(new byte[3] { content[globalCounter], content[globalCounter + 1], content[globalCounter + 2] }) * Math.Pow(2, -7);
                globalCounter += 3;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Air Speed
        public AirSpeed airSpeed;
        public class AirSpeed
        {
            public readonly string im;
            public readonly double airSpeed;
            public AirSpeed(byte[] content, int globalCounter)
            {
                var asVal = concatToInt16(new byte[2] { (byte)(content[globalCounter] & 0x7F), content[globalCounter + 1] });
                if (((content[globalCounter] >> 7) & 0b1) == 0) { im = "IAS"; airSpeed = asVal * Math.Pow(2, -14); }
                else { im = "Mach"; airSpeed = asVal * Math.Pow(10, -3); }
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region True Airspeed
        public TrueAirspeed trueAirspeed;
        public class TrueAirspeed
        {
            public readonly bool rangeExceeded;
            public readonly ushort trueAirspeed;
            public TrueAirspeed(byte[] content, int globalCounter)
            {
                trueAirspeed = concatToInt16(new byte[2] { (byte)(content[globalCounter] & 0x7F), content[globalCounter + 1] });
                if (((content[globalCounter] >> 7) & 0b1) == 0) { rangeExceeded = false; }
                else { rangeExceeded = true; }
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #endregion

        #region Funciones
        static public ushort concatToInt16(byte[] byteArray)
        {
            return (ushort)((byteArray[0] << 8) | byteArray[1]);
        }
        static public int concatToInt32(byte[] byteArray)
        {
            if (byteArray.Length == 3)
            {
                return (byteArray[0] << 16) | (byteArray[1] << 8) | byteArray[2];
            }
            else
            {
                return ((byteArray[0] << 24) | (byteArray[1] << 16)) | (byteArray[2] << 8) | byteArray[3];
            }
        }
        static public void updateCounter(int oldCounter)
        {
            iiGlobalCounter = oldCounter;
        }
        public static int compl2(int value)
        {
            if ((value & 0x80) != 0) { return (~(value) - 0x1) * -1; }
            else return value;
        }
        #endregion
    }
}
