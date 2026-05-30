using System;

namespace EmergencyDispatchSystem.Core
{
    public enum UnitStatus
    {
        Available,
        EnRoute,
        OnScene,
        Unavailable
    }

    public abstract class RespondingUnit
    {
        private string unitId;
        private UnitStatus status;
        private string location;

        protected RespondingUnit(string unitId, string location)
        {
            this.unitId = unitId;
            this.status = UnitStatus.Available;
            this.location = location;
        }

        public string UnitId
        {
            get { return unitId; }
            protected set { unitId = value; }
        }

        public UnitStatus Status
        {
            get { return status; }
            protected set { status = value; }
        }

        public string Location
        {
            get { return location; }
            protected set { location = value; }
        }

        public void setStatus(UnitStatus s)
        {
            this.status = s;
        }

        // Check if the unit is avaliable for case assignment
        public bool isAvailable()
        {
            return this.status == UnitStatus.Available;
        }
    }
}
