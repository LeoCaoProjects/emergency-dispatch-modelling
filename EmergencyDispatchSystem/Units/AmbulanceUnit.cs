using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.Units
{
    public class AmbulanceUnit : RespondingUnit
    {
        private int crewSize;
        private string vehicleType;
        private UnitStatus status;

        public AmbulanceUnit(string unitId, string location, int crewSize, string vehicleType)
            : base(unitId, location)
        {
            this.crewSize = crewSize;
            this.vehicleType = vehicleType;
            this.status = UnitStatus.Available;
        }

        public int CrewSize
        {
            get { return crewSize; }
            set { crewSize = value; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public bool isAvailable()
        {
            return status == UnitStatus.Available;
        }

        public void flagIssue(string desc)
        {
            Console.WriteLine("[" + UnitId + "] Issue flagged: " + desc);
        }

        public void updateStatus(UnitStatus status)
        {
            this.status = status;
            Console.WriteLine("[" + UnitId + "] Status updated to: " + status);
        }
    }
}
