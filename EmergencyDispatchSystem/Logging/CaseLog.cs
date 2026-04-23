using System;

namespace EmergencyDispatchSystem.Logging
{
    public class CaseLog
    {
        private string logId;
        private string caseId;
        private string action;
        private DateTime timestamp;
        private string performedBy;

        public CaseLog(string logId, string caseId, string action, string performedBy)
        {
            this.logId = logId;
            this.caseId = caseId;
            this.action = action;
            this.timestamp = DateTime.UtcNow;
            this.performedBy = performedBy;
        }

        public string LogId
        {
            get { return logId; }
        }

        public string CaseId
        {
            get { return caseId; }
        }

        public string Action
        {
            get { return action; }
        }

        public DateTime Timestamp
        {
            get { return timestamp; }
        }

        public string PerformedBy
        {
            get { return performedBy; }
        }

        // Create a entry when an action happens
        public void createEntry(string caseId, string action)
        {
            Console.WriteLine("[LOG] " + timestamp.ToString("HH:mm:ss") + ", Case " + caseId + ", " + action + ", By: " + performedBy);
        }
    }
}