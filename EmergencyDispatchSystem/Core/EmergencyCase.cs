using System;
using System.Collections.Generic;
using EmergencyDispatchSystem.EmergencyTypes;

namespace EmergencyDispatchSystem.Core
{
    public enum SeverityLevel
    {
        Low,
        Medium,
        High,
        Critical
    }

    public enum CaseStatus
    {
        Pending,
        Active,
        Resolved,
        Closed
    }

    public class EmergencyCase
    {
        private string caseId;
        private string location;
        private SeverityLevel severityLevel;
        private CaseStatus status;
        private DateTime timestamp;
        private IEmergencyType type;
        private List<RespondingUnit> assignedUnits;

        public EmergencyCase(string caseId, string location)
        {
            this.caseId = caseId;
            this.location = location;
            this.severityLevel = SeverityLevel.Low;
            this.status = CaseStatus.Pending;
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

        public SeverityLevel SeverityLevel
        {
            get { return severityLevel; }
            set { severityLevel = value; }
        }

        public CaseStatus Status
        {
            get { return status; }
        }

        public DateTime Timestamp
        {
            get { return timestamp; }
        }

        public IEmergencyType Type
        {
            get { return type; }
            set { type = value; }
        }

        public List<RespondingUnit> AssignedUnits
        {
            get { return assignedUnits; }
        }

        public void setStatus(CaseStatus status)
        {
            this.status = status;
        }

        public CaseStatus getStatus()
        {
            return this.status;
        }

        // Asigning a unit to the case
        public void addUnit(RespondingUnit u)
        {
            this.assignedUnits.Add(u);
            Console.WriteLine("[EmergencyCase] Unit " + u.UnitId + " added to Case " + caseId);
        }
    }
}
