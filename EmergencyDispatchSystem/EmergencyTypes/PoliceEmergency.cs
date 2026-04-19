using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.EmergencyTypes
{
    public class PoliceEmergency : EmergencyType
    {
        private string threatLevel;
        private bool suspectPresent;

        public PoliceEmergency(string threatLevel, bool suspectPresent)
            : base("POL", "Police Emergency")
        {
            this.threatLevel = threatLevel;
            this.suspectPresent = suspectPresent;
        }

        public string ThreatLevel
        {
            get { return threatLevel; }
            set { threatLevel = value; }
        }

        public bool SuspectPresent
        {
            get { return suspectPresent; }
            set { suspectPresent = value; }
        }

        public override string getTypeDetails()
        {
            return "";
        }

        public string getThreatLevel()
        {
            return "";
        }
    }
}
