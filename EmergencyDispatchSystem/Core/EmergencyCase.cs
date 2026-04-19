using System;
using System.Collections.Generic;

namespace EmergencyDispatchSystem.Core
{
    public class EmergencyCase
    {
        private string caseId;
        private string location;
        private string severityLevel;
        private string status;
        private DateTime timestamp;
        private EmergencyType type;
        private List<RespondingUnit> assignedUnits;

        public EmergencyCase(string caseId, string location)
        {
            this.caseId = caseId;
            this.location = location;
            this.severityLevel = "";
            this.status = "Pending";
            this.timestamp = DateTime.UtcNow;
            this.type = null;
            this.assignedUnits = new List<RespondingUnit>();
        }

        public string CaseId
        {
            get { return caseId; }
        }

        public string Location
        {
            get { return location; }
        }

        public string SeverityLevel
        {
            get { return severityLevel; }
            set { severityLevel = value; }
        }

        public string Status
        {
            get { return status; }
        }

        public DateTime Timestamp
        {
            get { return timestamp; }
        }

        public EmergencyType Type
        {
            get { return type; }
            set { type = value; }
        }

        public List<RespondingUnit> AssignedUnits
        {
            get { return assignedUnits; }
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getStatus()
        {
            return this.status;
        }

        public void addUnit(RespondingUnit u)
        {
            this.assignedUnits.Add(u);
            Console.WriteLine("[EmergencyCase] Unit " + u.UnitId + " added to Case " + caseId);
        }
    }
}