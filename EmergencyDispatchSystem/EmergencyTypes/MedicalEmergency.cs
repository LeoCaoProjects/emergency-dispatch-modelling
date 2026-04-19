using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.EmergencyTypes
{
    public class MedicalEmergency : EmergencyType
    {
        private string patientCondition;
        private bool requiresTransport;

        public MedicalEmergency(string patientCondition, bool requiresTransport)
            : base("MED", "Medical Emergency")
        {
            this.patientCondition = patientCondition;
            this.requiresTransport = requiresTransport;
        }

        public string PatientCondition
        {
            get { return patientCondition; }
            set { patientCondition = value; }
        }

        public bool RequiresTransport
        {
            get { return requiresTransport; }
            set { requiresTransport = value; }
        }

        public override string getTypeDetails()
        {
            return "(Medical) Condition: " + patientCondition + ", Transport Required: " + requiresTransport;
        }

        public bool needsTransport()
        {
            return this.requiresTransport;
        }
    }
}