using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.Operations
{
    public class CallCentreOperator
    {
        private string operatorId;
        private string name;
        private PriorityQueue priorityQueue;

        public CallCentreOperator(string operatorId, string name, PriorityQueue priorityQueue)
        {
            this.operatorId = operatorId;
            this.name = name;
            this.priorityQueue = priorityQueue;
        }

        public string OperatorId
        {
            get { return operatorId; }
        }

        public string Name
        {
            get { return name; }
        }

        // Create and log an case whenever the operator recieves an emergency call
        public EmergencyCase logEmergencyCall()
        {
            string caseId = DateTime.UtcNow.Ticks.ToString().Substring(10, 5);
            EmergencyCase ec = new EmergencyCase(caseId, "NZ");
            Console.WriteLine("[Call Centre Operator " + operatorId + "] Emergency call logged for Case ID " + caseId);
            priorityQueue.enqueue(ec);
            return ec;
        }

        // Update the severity level of the case
        public void assignSeverityLevel(EmergencyCase c)
        {
            c.SeverityLevel = SeverityLevel.Critical;
            Console.WriteLine("[Call Centre Operator " + operatorId + "] Severity set to Critical for Case " + c.CaseId);
        }
    }
}