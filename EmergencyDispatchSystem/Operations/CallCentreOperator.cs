using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.Operations
{
    public class CallCentreOperator
    {
        private string operatorId;
        private string name;

        public CallCentreOperator(string operatorId, string name)
        {
            this.operatorId = operatorId;
            this.name = name;
        }

        public string OperatorId
        {
            get { return operatorId; }
        }

        public string Name
        {
            get { return name; }
        }

        public EmergencyCase logEmergencyCall()
        {
            string caseId = DateTime.UtcNow.Ticks.ToString().Substring(10, 5);
            EmergencyCase ec = new EmergencyCase(caseId, "NZ");
            Console.WriteLine("[Call Centre Operator " + operatorId + "] Emergency call logged for Case ID " + caseId);
            return ec;
        }

        public void assignSeverityLevel(EmergencyCase c)
        {
            c.SeverityLevel = "Critical";
            Console.WriteLine("[Call Centre Operator " + operatorId + "] Severity set to Critical for Case " + c.CaseId);
        }
    }
}