using System;
using System.Collections.Generic;

namespace EmergencyDispatchSystem.Logging
{
    public class CaseLogRepository
    {
        private List<CaseLog> logs;

        public CaseLogRepository()
        {
            this.logs = new List<CaseLog>();
        }

        public List<CaseLog> Logs
        {
            get { return logs; }
        }

        public void save(CaseLog log)
        {
        }

        public List<CaseLog> findByCaseId(string id)
        {
            return new List<CaseLog>();
        }
    }
}
