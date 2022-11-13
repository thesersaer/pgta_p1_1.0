using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class AircraftOperationalStatus
    {
        bool tcasResolutionAdvisoryActive;
        string targetTrajectoryChangeReportCapability;
        bool targetStateReportCapability;
        bool airReferencedVelocityReportCapability;
        bool cdtiOperational;
        bool tcasOperational;
        bool singleAntenna;

        public AircraftOperationalStatus(DataField dataField)
        {
            int byteArray = int.Parse(dataField.getDataField()[0], System.Globalization.NumberStyles.HexNumber);
            singleAntenna = ((byteArray >> 0) & 1) != 0;
            tcasOperational = ((byteArray >> 1) & 1) != 0;
            cdtiOperational = ((byteArray >> 2) & 1) != 0;
            airReferencedVelocityReportCapability = ((byteArray >> 3) & 1) != 0;
            targetStateReportCapability = ((byteArray >> 4) & 1) != 0;
            int targetTrajectoryChangeReportCapabilityBit = ((byteArray >> 5) & 3);
            if (targetTrajectoryChangeReportCapabilityBit == 0) { targetTrajectoryChangeReportCapability = "none"; }
            else if (targetTrajectoryChangeReportCapabilityBit == 1) { targetTrajectoryChangeReportCapability = "tc+0"; }
            else if (targetTrajectoryChangeReportCapabilityBit == 2) { targetTrajectoryChangeReportCapability = "tc"; }
            else if (targetTrajectoryChangeReportCapabilityBit == 3) { targetTrajectoryChangeReportCapability = "reserved"; }
            tcasResolutionAdvisoryActive = ((byteArray >> 7) & 1) != 0;
        }
        public bool getTcasResolutionAdvisoryActive() { return tcasResolutionAdvisoryActive; }
        public string getTargetTrajectoryChangeReportCapability() { return targetTrajectoryChangeReportCapability; }
        public bool getTargetStateReportCapability() { return targetStateReportCapability; }
        public bool getAirReferencedVelocityReportCapability() { return airReferencedVelocityReportCapability; }
        public bool getCdtiOperational() { return cdtiOperational; }
        public bool getTcasOperational() { return tcasOperational; }
        public bool getSingleAntenna() { return singleAntenna; }
    }
}
