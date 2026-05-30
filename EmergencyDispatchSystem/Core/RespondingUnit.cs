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
        private string location;

        protected RespondingUnit(string unitId, string location)
        {
            this.unitId = unitId;
            this.location = location;
        }

        public string UnitId
        {
            get { return unitId; }
            protected set { unitId = value; }
        }

        public string Location
        {
            get { return location; }
            protected set { location = value; }
        }
    }
}
