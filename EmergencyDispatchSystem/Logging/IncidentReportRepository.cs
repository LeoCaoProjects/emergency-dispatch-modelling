using System;
using System.Collections.Generic;

namespace EmergencyDispatchSystem.Logging
{
    public class IncidentReportRepository
    {
        private List<IncidentReport> reports;

        public IncidentReportRepository()
        {
            this.reports = new List<IncidentReport>();
        }

        public List<IncidentReport> Reports
        {
            get { return reports; }
        }

        public void save(IncidentReport report)
        {
        }

        public IncidentReport findByCaseId(string id)
        {
            return null;
        }
    }
}
