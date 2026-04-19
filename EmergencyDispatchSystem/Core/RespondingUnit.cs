using System;

namespace EmergencyDispatchSystem.Core
{
    public abstract class RespondingUnit
    {
        private string unitId;
        private string status;
        private string location;

        protected RespondingUnit(string unitId, string location)
        {
            this.unitId = unitId;
            this.status = "Available";
            this.location = location;
        }

        public string UnitId
        {
            get { return unitId; }
            protected set { unitId = value; }
        }

        public string Status
        {
            get { return status; }
            protected set { status = value; }
        }

        public string Location
        {
            get { return location; }
            protected set { location = value; }
        }

        public void setStatus(string s)
        {
        }

        public bool isAvailable()
        {
            return false;
        }
    }
}
