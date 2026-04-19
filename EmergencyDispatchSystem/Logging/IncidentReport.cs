using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.Logging
{
    public class IncidentReport
    {
        private string reportId;
        private string caseId;
        private DateTime generatedAt;
        private string outcome;

        public IncidentReport()
        {
            this.reportId = "";
            this.caseId = "";
            this.generatedAt = DateTime.UtcNow;
            this.outcome = "";
        }

        public string ReportId
        {
            get { return reportId; }
        }

        public string CaseId
        {
            get { return caseId; }
        }

        public DateTime GeneratedAt
        {
            get { return generatedAt; }
        }

        public string Outcome
        {
            get { return outcome; }
        }

        public void generateReport(EmergencyCase c)
        {
        }
    }
}
