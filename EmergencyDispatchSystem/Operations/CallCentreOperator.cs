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
            return null;
        }

        public void assignSeverityLevel(EmergencyCase c)
        {
        }
    }
}
