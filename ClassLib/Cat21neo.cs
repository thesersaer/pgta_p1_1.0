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
        public readonly ushort len;

        #region Constructors
        public Cat21neo() { }
        public Cat21neo(string[] stringArray)
        {
            //Translating hex string array to byte array
            contentArray = new byte[stringArray.Length];
            for (int iiByteStr = 0; iiByteStr < stringArray.Length; iiByteStr++)
            {
                contentArray[iiByteStr] = byte.Parse(stringArray[iiByteStr], System.Globalization.NumberStyles.HexNumber);
            }
            this.len = concatToInt16(contentArray[1],contentArray[2]);

            iiGlobalCounter = 3;
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
                else if (frnInt == 10) { trueAirspeed = new TrueAirspeed(contentArray, iiGlobalCounter); }
                else if (frnInt == 11) { targetAddress = new TargetAddress(contentArray, iiGlobalCounter); }
                else if (frnInt == 12) { timeOfMessageReceptionPosition = new TimeOfMessageReceptionPosition(contentArray, iiGlobalCounter); }
                else if (frnInt == 13) { timeOfMessageReceptionPositionHP = new TimeOfMessageReceptionPositionHP(contentArray, iiGlobalCounter, timeOfMessageReceptionPosition); }
                else if (frnInt == 14) { timeOfMessageReceptionVelocity = new TimeOfMessageReceptionVelocity(contentArray, iiGlobalCounter); }
                else if (frnInt == 15) { timeOfMessageReceptionVelocityHP = new TimeOfMessageReceptionVelocityHP(contentArray, iiGlobalCounter, timeOfMessageReceptionVelocity); }
                else if (frnInt == 16) { geometricHeight = new GeometricHeight(contentArray, iiGlobalCounter); }
                else if (frnInt == 17) { qualityIndicators = new QualityIndicators(contentArray, iiGlobalCounter); }
                else if (frnInt == 18) { mOPSVersion = new MOPSVersion(contentArray, iiGlobalCounter); }
                else if (frnInt == 19) { mode3ACode = new Mode3ACode(contentArray, iiGlobalCounter); }
                else if (frnInt == 20) { rollAngle = new RollAngle(contentArray, iiGlobalCounter); }
                else if (frnInt == 21) { flightLevel = new FlightLevel(contentArray, iiGlobalCounter); }
                else if (frnInt == 22) { magneticHeading = new MagneticHeading(contentArray, iiGlobalCounter); }
                else if (frnInt == 23) { targetStatus = new TargetStatus(contentArray, iiGlobalCounter); }
                else if (frnInt == 24) { barometricVerticalRate = new BarometricVerticalRate(contentArray, iiGlobalCounter); }
                else if (frnInt == 25) { geometricVerticalRate = new GeometricVerticalRate(contentArray, iiGlobalCounter); }
                else if (frnInt == 26) { airborneGroundVector = new AirborneGroundVector(contentArray, iiGlobalCounter); }
                else if (frnInt == 27) { trackAngleRate = new TrackAngleRate(contentArray, iiGlobalCounter); }
                else if (frnInt == 28) { timeOfAsterixReport = new TimeOfAsterixReport(contentArray, iiGlobalCounter); }
                else if (frnInt == 29) { targetIdentification = new TargetIdentification(contentArray, iiGlobalCounter); }
                else if (frnInt == 30) { emitterCategory = new EmitterCategory(contentArray, iiGlobalCounter); }
                else if (frnInt == 31) { metInformation = new MetInformation(contentArray, iiGlobalCounter); }
                else if (frnInt == 32) { selectedAltitude = new SelectedAltitude(contentArray, iiGlobalCounter); }
                else if (frnInt == 33) { finalStateSelectedAltitude = new FinalStateSelectedAltitude(contentArray, iiGlobalCounter); }
                else if (frnInt == 34) { trajectoryIntent = new TrajectoryIntent(contentArray, iiGlobalCounter); }
                else if (frnInt == 35) { serviceManagement = new ServiceManagement(contentArray, iiGlobalCounter); }
                else if (frnInt == 36) { aircraftOperationalStatus = new AircraftOperationalStatus(contentArray, iiGlobalCounter); }
                else if (frnInt == 37) { surfaceCapabilitiesAndCharacteristics = new SurfaceCapabilitiesAndCharacteristics(contentArray, iiGlobalCounter); }
                else if (frnInt == 38) { messageAmplitude = new MessageAmplitude(contentArray, iiGlobalCounter); }
                else if (frnInt == 39) { modeSMBData = new ModeSMBData(contentArray, iiGlobalCounter); }
                else if (frnInt == 40) { aCASResolutionAdvisoryReport = new ACASResolutionAdvisoryReport(contentArray, iiGlobalCounter); }
                else if (frnInt == 41) { receiverId = new ReceiverId(contentArray, iiGlobalCounter); }
                else if (frnInt == 42) { dataAges = new DataAges(contentArray, iiGlobalCounter); }
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
                this.trackNumber = concatToInt16(content[globalCounter], content[globalCounter + 1]);
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
                this.toaSeconds = concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2])*Math.Pow(2,-7);
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
                this.latitude = compl2(concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]),24) * resFact;
                globalCounter += 3;
                this.longitude = compl2(concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]),24) * resFact;
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
                this.latitude = compl2(concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2], content[globalCounter + 3]),32) * resFact;
                globalCounter += 4;
                this.longitude = compl2(concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2], content[globalCounter + 3]),32) * resFact;
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
                this.toaSeconds = concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]) * Math.Pow(2, -7);
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
                var asVal = concatToInt16((byte)(content[globalCounter] & 0x7F), content[globalCounter + 1]);
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
                trueAirspeed = concatToInt16((byte)(content[globalCounter] & 0x7F), content[globalCounter + 1]);
                if (((content[globalCounter] >> 7) & 0b1) == 0) { rangeExceeded = false; }
                else { rangeExceeded = true; }
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Target Address
        public TargetAddress targetAddress;
        public class TargetAddress
        {
            public readonly int targetAddress;
            public TargetAddress(byte[] content, int globalCounter)
            {
                targetAddress = concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]);
                globalCounter += 3;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Time of Message Reception for Position
        public TimeOfMessageReceptionPosition timeOfMessageReceptionPosition;
        public class TimeOfMessageReceptionPosition
        {
            public readonly double tomSeconds;
            public TimeOfMessageReceptionPosition(byte[] content, int globalCounter)
            {
                tomSeconds = concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]) * Math.Pow(2, -7);
                globalCounter += 3;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Time of Message Reception for Position–High Precision
        public TimeOfMessageReceptionPositionHP timeOfMessageReceptionPositionHP;
        public class TimeOfMessageReceptionPositionHP
        {
            public readonly bool fsiReserved = false;
            public readonly double tomSeconds;
            public TimeOfMessageReceptionPositionHP(byte[] content, int globalCounter, TimeOfMessageReceptionPosition tomrp)
            {
                var fsiVal = (content[globalCounter] >> 6) & 0b11;
                var fraccSeconds = concatToInt32((byte)(content[globalCounter] & 0x3F), content[globalCounter + 1], content[globalCounter + 2], content[globalCounter + 3]);
                tomSeconds = fraccSeconds * Math.Pow(2, -30);
                if (fsiVal == 0b00) { tomSeconds += Math.Truncate(tomrp.tomSeconds); }
                else if (fsiVal == 0b01) { tomSeconds += Math.Truncate(tomrp.tomSeconds) + 1; }
                else if (fsiVal == 0b10) { tomSeconds += Math.Truncate(tomrp.tomSeconds) - 1; }
                else { fsiReserved = true; }
                globalCounter += 4;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Time of Message Reception of Velocity
        public TimeOfMessageReceptionVelocity timeOfMessageReceptionVelocity;
        public class TimeOfMessageReceptionVelocity
        {
            public readonly double tomSeconds;
            public TimeOfMessageReceptionVelocity(byte[] content, int globalCounter)
            {
                tomSeconds = concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]) * Math.Pow(2, -7);
                globalCounter += 3;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Time of Message Reception of Velocity–High Precision
        public TimeOfMessageReceptionVelocityHP timeOfMessageReceptionVelocityHP;
        public class TimeOfMessageReceptionVelocityHP
        {
            public readonly bool fsiReserved = false;
            public readonly double tomSeconds;
            public TimeOfMessageReceptionVelocityHP(byte[] content, int globalCounter, TimeOfMessageReceptionVelocity tomrv)
            {
                var fsiVal = (content[globalCounter] >> 6) & 0b11;
                var fraccSeconds = concatToInt32((byte)(content[globalCounter] & 0x3F), content[globalCounter + 1], content[globalCounter + 2], content[globalCounter + 3]);
                tomSeconds = fraccSeconds * Math.Pow(2, -30);
                if (fsiVal == 0b00) { tomSeconds += Math.Truncate(tomrv.tomSeconds); }
                else if (fsiVal == 0b01) { tomSeconds += Math.Truncate(tomrv.tomSeconds) + 1; }
                else if (fsiVal == 0b10) { tomSeconds += Math.Truncate(tomrv.tomSeconds) - 1; }
                else { fsiReserved = true; }
                globalCounter += 4;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Geometric Height
        public GeometricHeight geometricHeight;
        public class GeometricHeight
        {
            public readonly bool greaterThan = false;
            public readonly double geometricHeight;
            public GeometricHeight(byte[] content, int globalCounter)
            {
                geometricHeight = concatToInt16(content[globalCounter], content[globalCounter + 1]) * 6.25;
                if (geometricHeight == 0x7FFF) { greaterThan = true; }
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Quality Indicators
        public QualityIndicators qualityIndicators;
        public class QualityIndicators
        {
            public readonly byte navigationAccuracyCategoryVelocity;
            public readonly byte navigationIntegrityCategoryPosition;
            public readonly byte navigationIntegrityCategoryBaroAlt;
            public readonly byte surveillanceIntegrityLevel;
            public readonly byte navigationAccuracyCategoryPosition;
            public readonly string silSupplement;
            public readonly byte horizontalPositionSystemDesignAssuranceLevel;
            public readonly byte geometricAltitudeAccuracyCategory;
            public readonly byte positionIntegrityCategory;
            public QualityIndicators(byte[] content, int globalCounter)
            {
                navigationAccuracyCategoryVelocity = (byte)((content[globalCounter] >> 5) & 0b111);
                navigationIntegrityCategoryPosition = (byte)((content[globalCounter] >> 1) & 0b111);
                if ((content[globalCounter] & 0b1) != 0) //First extension
                {
                    globalCounter++;
                    navigationIntegrityCategoryBaroAlt = (byte)((content[globalCounter] >> 7) & 0b1);
                    surveillanceIntegrityLevel = (byte)((content[globalCounter] >> 5) & 0b11);
                    navigationAccuracyCategoryPosition = (byte)((content[globalCounter] >> 1) & 0b1111);
                    if ((content[globalCounter] & 0b1) != 0) //Second extension
                    {
                        globalCounter++;
                        if (((content[globalCounter] >> 5) & 0b1) != 0) { silSupplement = "Measured per sample"; }
                        else { silSupplement = "Measured per flight-hour"; }
                        horizontalPositionSystemDesignAssuranceLevel = (byte)((content[globalCounter] >> 3) & 0b11);
                        geometricAltitudeAccuracyCategory = (byte)((content[globalCounter] >> 1) & 0b11);
                        if ((content[globalCounter] & 0b1) != 0) //Third extension
                        {
                            globalCounter++;
                            positionIntegrityCategory = (byte)((content[globalCounter] >> 4) & 0b1111);
                        }
                    }
                }
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region MOPS Version
        public MOPSVersion mOPSVersion;
        public class MOPSVersion
        {
            public readonly bool versionNotSupported;
            public readonly string versionNumber;
            public readonly string linkTechnologyType;
            public MOPSVersion(byte[] content, int globalCounter)
            {
                versionNotSupported = ((content[globalCounter] >> 6) & 0b1) != 0;
                int vnInt = (content[globalCounter] >> 3) & 0b111;
                int lttInt = content[globalCounter] & 0b111;
                if (lttInt > 3) { linkTechnologyType = "Not assigned"; }
                else if (lttInt > 2) { linkTechnologyType = "VDL 4"; }
                else if (lttInt > 1)
                {
                    linkTechnologyType = "1090 ES";
                    if (vnInt > 1) { versionNumber = "ED102A/DO-260B [Ref. 11]"; }
                    else if (vnInt > 0) { versionNumber = "DO-260A [Ref. 9]"; }
                    else { versionNumber = "ED102/DO-260 [Ref. 8]"; }
                }
                else if (lttInt > 0) { linkTechnologyType = "UAT"; }
                else { linkTechnologyType = "Other"; }
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Mode 3/A Code in Octal Representation
        public Mode3ACode mode3ACode;
        public class Mode3ACode
        {
            public readonly string replyCode; //Octal string
            public Mode3ACode(byte[] content, int globalCounter)
            {
                var codeVal = concatToInt16(content[globalCounter], content[globalCounter + 1]);
                replyCode = Convert.ToString(codeVal, 8);
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Roll Angle
        public RollAngle rollAngle;
        public class RollAngle
        {
            public readonly double rollAngle; //cw wrt rear view

            public RollAngle(byte[] content, int globalCounter)
            {
                rollAngle = compl2(concatToInt16(content[globalCounter], content[globalCounter + 1]), 16) * 0.01;
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Flight Level
        public FlightLevel flightLevel;
        public class FlightLevel
        {
            public readonly double flightLevel;
            public FlightLevel(byte[] content, int globalCounter)
            {
                flightLevel = compl2(concatToInt16(content[globalCounter], content[globalCounter + 1]),16) * 0.25;
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Magnetic Heading
        public MagneticHeading magneticHeading;
        public class MagneticHeading
        {
            public readonly double magneticHeading;
            public MagneticHeading(byte[] content, int globalCounter)
            {
                magneticHeading = concatToInt16(content[globalCounter], content[globalCounter + 1]) * (360 / Math.Pow(2, 16));
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Target Status
        public TargetStatus targetStatus;
        public class TargetStatus
        {
            public readonly bool intentChangeFlag;
            public readonly bool lnavModeNotEngaged;
            public readonly string priorityStatus;
            public readonly string surveillanceStatus;
            public TargetStatus(byte[] content, int globalCounter)
            {
                intentChangeFlag = ((content[globalCounter] >> 7) & 0b1) != 0;
                lnavModeNotEngaged = ((content[globalCounter] >> 6) & 0b1) != 0;
                int psInt = (content[globalCounter] >> 2) & 0b111;
                if (psInt == 0) { priorityStatus = "No emergency / Not reported"; }
                else if (psInt == 1) { priorityStatus = "General emergency"; }
                else if (psInt == 2) { priorityStatus = "Lifeguard / medical emergency"; }
                else if (psInt == 3) { priorityStatus = "Minimum fuel"; }
                else if (psInt == 4) { priorityStatus = "No communications"; }
                else if (psInt == 5) { priorityStatus = "Unlawful interference"; }
                else { priorityStatus = "Downed aircraft"; }
                int ssInt = content[globalCounter] & 0b11;
                if (ssInt == 0) { surveillanceStatus = "No condition reported"; }
                else if (ssInt == 1) { surveillanceStatus = "Permanent Alert"; }
                else if (ssInt == 2) { surveillanceStatus = "Temporary Alert"; }
                else { surveillanceStatus = "SPI set"; }
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Barometric Vertical Rate
        public BarometricVerticalRate barometricVerticalRate;
        public class BarometricVerticalRate
        {
            public readonly bool rangeExceeded;
            public readonly double barometricVerticalRateFtPerMin;
            public BarometricVerticalRate(byte[] content, int globalCounter)
            {
                rangeExceeded = ((content[globalCounter] >> 7) & 0b1) != 0;
                barometricVerticalRateFtPerMin = compl2(concatToInt16((byte)(content[globalCounter] & 0x7F), content[globalCounter + 1]),15) * 6.25;
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Geometric Vertical Rate
        public GeometricVerticalRate geometricVerticalRate;
        public class GeometricVerticalRate
        {
            public readonly bool rangeExceeded;
            public readonly double geometricVerticalRateFtPerMin;
            public GeometricVerticalRate(byte[] content, int globalCounter)
            {
                rangeExceeded = ((content[globalCounter] >> 7) & 0b1) != 0;
                geometricVerticalRateFtPerMin = compl2(concatToInt16((byte)(content[globalCounter] & 0x7F), content[globalCounter + 1]),15) * 6.25;
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Airborne Ground Vector
        public AirborneGroundVector airborneGroundVector;
        public class AirborneGroundVector
        {
            public readonly bool rangeExceeded;
            public readonly double groundSpeed;
            public readonly double trackAngle; //cw wrt true north
            public AirborneGroundVector(byte[] content, int globalCounter)
            {
                rangeExceeded = ((content[globalCounter] >> 7) & 0b1) != 0;
                groundSpeed = concatToInt16((byte)(content[globalCounter] & 0x7F), content[globalCounter + 1]) * Math.Pow(2, -14);
                globalCounter += 2;
                trackAngle = concatToInt16(content[globalCounter], content[globalCounter + 1]) * (360 / Math.Pow(2, 16));
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Track Angle Rate
        public TrackAngleRate trackAngleRate;
        public class TrackAngleRate
        {
            public readonly double trackAngleRate;
            public TrackAngleRate(byte[] content, int globalCounter)
            {
                trackAngleRate = compl2(concatToInt16(content[globalCounter], content[globalCounter + 1]),10) * (1 / 32);
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Time Of ASTERIX Report Transmission
        public TimeOfAsterixReport timeOfAsterixReport;
        public class TimeOfAsterixReport
        {
            public readonly double torSeconds;
            public TimeOfAsterixReport(byte[] content, int globalCounter)
            {
                torSeconds = concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]) * Math.Pow(2, -7);
                globalCounter += 3;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Target Identification
        public TargetIdentification targetIdentification;
        public class TargetIdentification
        {
            public readonly string targetIdentification = "";
            public TargetIdentification(byte[] content, int globalCounter)
            {
                string tiStr = "";
                string tiDecodedStr = "";
                for (int iiOctet = 0; iiOctet < 6; iiOctet++)
                {
                    tiStr += Convert.ToString(content[globalCounter + iiOctet], 2).PadLeft(8, '0');
                }
                for (int iiStr = 0; iiStr < tiStr.Length; iiStr += 6)
                {
                    string charStr = tiStr.Substring(iiStr, 6);
                    tiDecodedStr += decodeTI(charStr);
                }
                targetIdentification = tiDecodedStr;
                globalCounter += 6;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Emitter Category
        public EmitterCategory emitterCategory;
        public class EmitterCategory
        {
            public readonly string emitterCategory;
            public EmitterCategory(byte[] content, int globalCounter)
            {
                byte ecat = content[globalCounter];
                if (ecat == 0) { emitterCategory = "No ADS-B Emitter Category Information"; }
                else if (ecat == 1) { emitterCategory = "light aircraft <= 15500 lbs"; }
                else if (ecat == 2) { emitterCategory = "15500 lbs < small aircraft <75000 lbs"; }
                else if (ecat == 3) { emitterCategory = "75000 lbs < medium a/c < 300000 lbs"; }
                else if (ecat == 4) { emitterCategory = "High Vortex Large"; }
                else if (ecat == 5) { emitterCategory = "300000 lbs <= heavy aircraft"; }
                else if (ecat == 6) { emitterCategory = "highly manoeuvrable (5g acceleration capability) and high speed(> 400 knots cruise)"; }
                else if (ecat == 7) { emitterCategory = "reserved"; }
                else if (ecat == 8) { emitterCategory = "reserved"; }
                else if (ecat == 9) { emitterCategory = "reserved"; }
                else if (ecat == 10) { emitterCategory = "rotocraft"; }
                else if (ecat == 11) { emitterCategory = "glider / sailplane"; }
                else if (ecat == 12) { emitterCategory = "lighter-than-air"; }
                else if (ecat == 13) { emitterCategory = "unmanned aerial vehicle"; }
                else if (ecat == 14) { emitterCategory = "space / transatmospheric vehicle"; }
                else if (ecat == 15) { emitterCategory = "ultralight / handglider / paraglider"; }
                else if (ecat == 16) { emitterCategory = "parachutist / skydiver"; }
                else if (ecat == 17) { emitterCategory = "reserved"; }
                else if (ecat == 18) { emitterCategory = "reserved"; }
                else if (ecat == 19) { emitterCategory = "reserved"; }
                else if (ecat == 20) { emitterCategory = "surface emergency vehicle"; }
                else if (ecat == 21) { emitterCategory = "surface service vehicle"; }
                else if (ecat == 22) { emitterCategory = "fixed ground or tethered obstruction"; }
                else if (ecat == 23) { emitterCategory = "cluster obstacle"; }
                else if (ecat == 24) { emitterCategory = "line obstacle"; }
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Met Information
        public MetInformation metInformation;
        public class MetInformation
        {
            public readonly ushort windSpeed;
            public readonly ushort windDirection;
            public readonly float temperature;
            public readonly byte turbulence;
            public MetInformation(byte[] content, int globalCounter)
            {
                Queue<int> fspecQueue = new Queue<int>();
                for (int iiFspec = 7; iiFspec > 3; iiFspec--)
                {
                    if (((content[globalCounter] >> iiFspec) & 0b1) == 1)
                    { fspecQueue.Enqueue(iiFspec); }
                }
                globalCounter++;
                foreach (int iiSubfield in fspecQueue)
                {
                    if (iiSubfield == 7)
                    {
                        windSpeed = concatToInt16(content[globalCounter], content[globalCounter + 1]);
                        globalCounter += 2;
                    }
                    else if (iiSubfield == 6)
                    {
                        windDirection = concatToInt16(content[globalCounter], content[globalCounter + 1]);
                        globalCounter += 2;
                    }
                    else if (iiSubfield == 5)
                    {
                        temperature = (float)(compl2(concatToInt16(content[globalCounter], content[globalCounter + 1]), 16) * 0.25);
                        globalCounter += 2;
                    }
                    else if (iiSubfield == 4)
                    {
                        turbulence = content[globalCounter];
                        globalCounter++;
                    }
                }
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Selected Altitude
        public SelectedAltitude selectedAltitude;
        public class SelectedAltitude
        {
            public readonly bool sourceInformationProvided;
            public readonly string source;
            public readonly short altitude;
            public SelectedAltitude(byte[] content, int globalCounter)
            {
                sourceInformationProvided = ((content[globalCounter] >> 7) & 0b1) != 0;
                int sourceInt = ((content[globalCounter] >> 5) & 0b11);
                if (sourceInt == 0) { source = "Unknown"; }
                else if (sourceInt == 0b1) { source = "Aircraft Altitude (Holding Altitude)"; }
                else if (sourceInt == 0b10) { source = "MCP/FCU Selected Altitude"; }
                else { source = "FMS Selected Altitude"; }
                altitude = (short)(compl2(concatToInt16((byte)(content[globalCounter] & 0x1F), content[globalCounter + 1]), 13) * 25);
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Final State Selected Altitude
        public FinalStateSelectedAltitude finalStateSelectedAltitude;
        public class FinalStateSelectedAltitude
        {
            public readonly bool manageVerticalModeActive;
            public readonly bool altitudeHoldModeActive;
            public readonly bool approachModeActive;
            public readonly short altitude;
            public FinalStateSelectedAltitude(byte[] content, int globalCounter)
            {
                manageVerticalModeActive = ((content[globalCounter] >> 7) & 0b1) != 0;
                altitudeHoldModeActive = ((content[globalCounter] >> 6) & 0b1) != 0;
                approachModeActive = ((content[globalCounter] >> 5) & 0b1) != 0;
                altitude = (short)(compl2(concatToInt16((byte)(content[globalCounter] & 0x1F), content[globalCounter + 1]),13) * 25);
                globalCounter += 2;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Trajectory Intent
        public TrajectoryIntent trajectoryIntent;
        public class TrajectoryIntent
        {
            public class TrajectoryIntentData
            {
                public readonly bool tcpNumberAvailable;
                public readonly bool tcpNonCompliance;
                public readonly byte tcpNumber;
                public readonly int altitude;
                public readonly double latitude;
                public readonly double longitude;
                public readonly string pointType;
                public readonly string turnDirection;
                public readonly bool turnRadiusAvailable;
                public readonly bool timeOverPointNotAvailable;
                public readonly int timeOverPoint;
                public readonly float tcpTurnRadius;
                public TrajectoryIntentData(byte[] content, int globalCounter)
                {
                    tcpNumberAvailable = ((content[globalCounter] >> 7) & 0b1) == 1;
                    tcpNonCompliance = ((content[globalCounter] >> 6) & 0b1) == 1;
                    tcpNumber = (byte)(content[globalCounter] & 0x3F);
                    globalCounter++;
                    altitude = compl2(concatToInt16(content[globalCounter], content[globalCounter + 1]), 16) * 10;
                    globalCounter += 2;
                    var llResFactor = 180 / Math.Pow(2, 23);
                    latitude = compl2(concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]), 24) * llResFactor;
                    globalCounter += 3;
                    longitude = compl2(concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]), 24) * llResFactor;
                    globalCounter += 3;
                    var ptVal = (content[globalCounter] >> 4) & 0b1111;
                    if (ptVal == 0) { pointType = "Unknown"; }
                    else if (ptVal == 1) { pointType = "Fly by waypoint (LT)"; }
                    else if (ptVal == 2) { pointType = "Fly over waypoint (LT)"; }
                    else if (ptVal == 3) { pointType = "Hold pattern (LT)"; }
                    else if (ptVal == 4) { pointType = "Procedure hold (LT)"; }
                    else if (ptVal == 5) { pointType = "Procedure turn (LT)"; }
                    else if (ptVal == 6) { pointType = "RF leg (LT)"; }
                    else if (ptVal == 7) { pointType = "Top of climb (VT)"; }
                    else if (ptVal == 8) { pointType = "Top of descent (VT)"; }
                    else if (ptVal == 9) { pointType = "Start of level (VT)"; }
                    else if (ptVal == 10) { pointType = "Cross-over altitude (VT)"; }
                    else if (ptVal == 11) { pointType = "Transition altitude (VT)"; }
                    var tdVal = (content[globalCounter] >> 2) & 0b11;
                    if (tdVal == 0) { turnDirection = "N/A"; }
                    else if (tdVal == 1) { turnDirection = "Turn right"; }
                    else if (tdVal == 2) { turnDirection = "Turn left"; }
                    else if (tdVal == 3) { turnDirection = "No turn"; }
                    timeOverPointNotAvailable = (content[globalCounter] & 0b1) == 1;
                    globalCounter++;
                    timeOverPoint = concatToInt32(content[globalCounter], content[globalCounter + 1], content[globalCounter + 2]);
                    globalCounter += 3;
                    tcpTurnRadius = (float)(concatToInt16(content[globalCounter], content[globalCounter + 1]) * 0.01);
                    globalCounter += 2;
                    updateCounter(globalCounter);
                }
            }
            public readonly bool trajectoryIntentDataNotAvailable;
            public readonly bool trajectoryIntentDataNotValid;
            public readonly TrajectoryIntentData[] trajectoryIntentDatas;
            public TrajectoryIntent(byte[] content, int globalCounter)
            {
                bool tisPresent = ((content[globalCounter] >> 7) & 0b1) == 1;
                bool tidPresent = ((content[globalCounter] >> 6) & 0b1) == 1;
                globalCounter++;
                if (tisPresent)
                {
                    trajectoryIntentDataNotAvailable = ((content[globalCounter] >> 7) & 0b1) == 1;
                    trajectoryIntentDataNotValid = ((content[globalCounter] >> 6) & 0b1) == 1;
                    globalCounter++;
                }
                if (tidPresent)
                {
                    int repFactor = content[globalCounter];
                    trajectoryIntentDatas = new TrajectoryIntentData[repFactor];
                    globalCounter++;
                    for (int x = 0; x < repFactor; x++)
                    {
                        trajectoryIntentDatas[x] = new TrajectoryIntentData(content, globalCounter);
                        globalCounter = iiGlobalCounter;
                    }
                }
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Service Management
        public ServiceManagement serviceManagement;
        public class ServiceManagement
        {
            public readonly float reportPeriod;
            // MAX reportPeriod == 127.5 indicates report period of 127.5 s OR ABOVE
            public ServiceManagement(byte[] content, int globalCounter)
            {
                reportPeriod = (float)(content[globalCounter] * 0.5);
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Aircraft Operational Status
        public AircraftOperationalStatus aircraftOperationalStatus;
        public class AircraftOperationalStatus
        {
            public readonly bool tcasResolutionAdvisoryActive;
            public readonly string targetTrajectoryChangeReportCapability;
            public readonly bool targetStateReportCapability;
            public readonly bool airReferencedVelocityReportCapability;
            public readonly bool cdtiOperational;
            public readonly bool tcasNotOperational;
            public readonly bool singleAntenna;
            public AircraftOperationalStatus(byte[] content, int globalCounter)
            {
                singleAntenna = ((content[globalCounter] >> 0) & 1) != 0;
                tcasNotOperational = ((content[globalCounter] >> 1) & 1) != 0;
                cdtiOperational = ((content[globalCounter] >> 2) & 1) != 0;
                airReferencedVelocityReportCapability = ((content[globalCounter] >> 3) & 1) != 0;
                targetStateReportCapability = ((content[globalCounter] >> 4) & 1) != 0;
                int targetTrajectoryChangeReportCapabilityBit = ((content[globalCounter] >> 5) & 3);
                if (targetTrajectoryChangeReportCapabilityBit == 0) { targetTrajectoryChangeReportCapability = "no capability for Trajectory Change Reports"; }
                else if (targetTrajectoryChangeReportCapabilityBit == 1) { targetTrajectoryChangeReportCapability = "support for TC+0 reports only"; }
                else if (targetTrajectoryChangeReportCapabilityBit == 2) { targetTrajectoryChangeReportCapability = "support for multiple TC reports"; }
                else if (targetTrajectoryChangeReportCapabilityBit == 3) { targetTrajectoryChangeReportCapability = "reserved"; }
                tcasResolutionAdvisoryActive = ((content[globalCounter] >> 7) & 1) != 0;
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Surface Capabilities And Characteristics
        public SurfaceCapabilitiesAndCharacteristics surfaceCapabilitiesAndCharacteristics;
        public class SurfaceCapabilitiesAndCharacteristics
        {
            public readonly bool positionIsADSBReferencePoint;
            public readonly bool cdtiOperational;
            public readonly bool b2LowPower; // <70 W if true
            public readonly bool receivingAtcServices;
            public readonly bool identSwitchActive;
            public readonly string lengthWidth;
            public SurfaceCapabilitiesAndCharacteristics(byte[] content, int globalCounter)
            {
                positionIsADSBReferencePoint = ((content[globalCounter] >> 5) & 0b1) != 0;
                cdtiOperational = ((content[globalCounter] >> 4) & 0b1) != 0;
                b2LowPower = ((content[globalCounter] >> 3) & 0b1) != 0;
                receivingAtcServices = ((content[globalCounter] >> 2) & 0b1) != 0;
                identSwitchActive = ((content[globalCounter] >> 1) & 0b1) != 0;
                if ((content[globalCounter] & 0b1) != 0) 
                {
                    globalCounter++;
                    lengthWidth = decodeLW((byte)(content[globalCounter] & 0xF)); 
                }
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Message Amplitude
        public MessageAmplitude messageAmplitude;
        public class MessageAmplitude
        {
            public readonly byte messageAmplitudedBm;
            public MessageAmplitude(byte[] content, int globalCounter)
            {
                messageAmplitudedBm = content[globalCounter];
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Mode S MB Data
        public ModeSMBData modeSMBData;
        public class ModeSMBData
        {
            public class BDSMessage
            {
                public readonly byte[] mbData = new byte[7];
                public readonly byte commBDS1Address;
                public readonly byte commBDS2Address;
                public BDSMessage(byte[] content, int globalCounter)
                {
                    for (int iiMBD = 0; iiMBD < 7; iiMBD++)
                    {
                        mbData[iiMBD] = content[globalCounter];
                        globalCounter++;

                    }
                    commBDS1Address = (byte)((content[globalCounter] >> 4) & 0b1111);
                    commBDS2Address = (byte)(content[globalCounter] & 0b1111);
                    globalCounter++;
                    updateCounter(globalCounter);
                }
            }
            public readonly BDSMessage[] bdsList;
            public ModeSMBData(byte[] content, int globalCounter)
            {
                int repFactor = content[globalCounter];
                bdsList = new BDSMessage[repFactor];
                for (int x = 0; x < repFactor; x++)
                {
                    bdsList[x] = new BDSMessage(content, globalCounter);
                    globalCounter = iiGlobalCounter;
                }
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region ACAS Resolution Advisory Report
        public ACASResolutionAdvisoryReport aCASResolutionAdvisoryReport;
        public class ACASResolutionAdvisoryReport
        {
            public readonly byte messageType;
            public readonly byte messageSubtype;
            public readonly ushort activeResolutionAdvisories;
            public readonly byte raComplementRecord;
            public readonly bool raTerminated;
            public readonly bool multipleThreatEncounter;
            public readonly byte threatTypeIndicator;
            public readonly int threatIdentityData;
            public ACASResolutionAdvisoryReport(byte[] content, int globalCounter)
            {
                messageType = (byte)((content[globalCounter] >> 3) & 0b11111);
                messageSubtype = (byte)(content[globalCounter] & 0b111);
                globalCounter++;
                activeResolutionAdvisories = (ushort)(((content[globalCounter + 1] >> 2) & 0x3F) | (content[globalCounter] << 6));
                raComplementRecord = (byte)(((content[globalCounter + 2] >> 6) & 0b11) | (content[globalCounter + 1] & 0b11));
                globalCounter += 2;
                raTerminated = ((content[globalCounter] >> 5) & 0b1) != 0;
                multipleThreatEncounter = ((content[globalCounter] >> 4) & 0b1) != 0;
                threatTypeIndicator = (byte)((content[globalCounter] >> 2) & 0b11);
                threatIdentityData = concatToInt32(content[globalCounter + 1], content[globalCounter + 2], content[globalCounter + 3]) | ((content[globalCounter] & 0b11) << 24);
                globalCounter += 4;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Receiver Id
        public ReceiverId receiverId;
        public class ReceiverId
        {
            public readonly byte receiverId;
            public ReceiverId(byte[] content, int globalCounter)
            {
                receiverId = content[globalCounter];
                globalCounter++;
                updateCounter(globalCounter);
            }
        }
        #endregion
        #region Data Ages
        public DataAges dataAges;
        public class DataAges
        {
            public class DataAgeItem
            {
                public readonly double age;
                public readonly string itemClass;
                public DataAgeItem(byte ageByte, string item)
                {
                    age = ageByte * 0.1;
                    itemClass = item;
                }
            }
            public readonly DataAgeItem[] ageItems;
            public DataAges(byte[] content, int globalCounter)
            {
                Queue<int> fspecQueue = new Queue<int>();
                bool fxInd;
                int subFInt = 32;
                do
                {
                    fxInd = (content[globalCounter] & 0b1) == 1;
                    for (int iiBit = 7; iiBit > 0; iiBit--)
                    {
                        if (((content[globalCounter] >> iiBit) & 0b1) == 1)
                        { 
                            fspecQueue.Enqueue(subFInt);
                        }
                        subFInt--;
                    }
                    subFInt--;
                    globalCounter++;
                } while (fxInd);
                var queueLength = fspecQueue.Count;
                ageItems = new DataAgeItem[queueLength];
                for (int iiFspec = 0; iiFspec < queueLength; iiFspec++)
                {
                    ageItems[iiFspec] = new DataAgeItem(content[globalCounter], decodeDA(fspecQueue.Dequeue()));
                    globalCounter++;
                }
                updateCounter(globalCounter);
            }
        }
        #endregion
        #endregion

        #region Funciones
        static public ushort concatToInt16(byte b0, byte b1)
        {
            return (ushort)((b0 << 8) | b1);
        }
        static public int concatToInt32(params byte[] vals)
        {
            if (vals.Length == 3)
            {
                return (vals[0] << 16) | (vals[1] << 8) | vals[2];
            }
            else
            {
                return ((vals[0] << 24) | (vals[1] << 16)) | (vals[2] << 8) | vals[3];
            }
        }
        static public void updateCounter(int oldCounter)
        {
            iiGlobalCounter = oldCounter;
        }
        public static int compl2(int value, int msbPos)
        {
            if (((value >> (msbPos-1)) & 0b1) != 0) 
            {
                var negated = ~(value) & (int)(Math.Pow(2, msbPos) - 1);
                return ( negated + 0x1) * -1; 
            }
            else return value;
        }
        public static string decodeTI(string str)
        {
            List<string> listCode = new List<string>() { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "", "", "", "", "", "" };
            return listCode[Convert.ToInt32(str, 2)];
        }
        public static string decodeLW(byte lwVal)
        {
            string[] listCode = new string[16] { "L < 15, W < 11.5", "L < 15, W < 23", "L < 25, W < 28.5", "L < 25, W < 34", "L < 35, W < 33", "L < 35, W < 38", "L < 45, W < 39.5", "L < 45, W < 45", "L < 55, W < 45", "L < 55, W < 52", "L < 65, W < 59.5", "L < 65, W < 67", "L < 75, W < 72.5", "L < 75, W < 80", "L < 85, W < 80", "L > 85, W > 80" };
            return listCode[lwVal];
        }
        public static string decodeDA(int daSubFVal)
        {
            string[] listCode = new string[33] { "", "", "", "", "", "", "", "Surface Capabilities and Characteristics", "ACAS Resolution Advisory", "", "Roll Angle", "Met Information", "Target Status", "Target Identification", "Track Angle Rate", "Ground Vector", "Geometric Vertical Rate", "", "Barometric Vertical Rate", "Magnetic Heading", "True Air Speed", "Air Speed", "Final State Selected Altitude", "Intermediate State Selected Altitude", "Flight Level", "", "Geometric Height", "Message Amplitude", "Trajectory Intent", "Quality Indicators", "Mode 3/A Code", "Target Report Descriptor", "Aircraft Operational Status" };
            return listCode[daSubFVal];
        }
        #endregion
    }
}
