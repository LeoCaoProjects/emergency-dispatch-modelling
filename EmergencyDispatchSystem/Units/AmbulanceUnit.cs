using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.Units
{
    public class AmbulanceUnit : RespondingUnit
    {
        private int crewSize;
        private string vehicleType;

        public AmbulanceUnit(string unitId, string location, int crewSize, string vehicleType)
            : base(unitId, location)
        {
            this.crewSize = crewSize;
            this.vehicleType = vehicleType;
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

        public void flagIssue(string desc)
        {
        }

        public void updateStatus(string status)
        {
        }
    }
}
