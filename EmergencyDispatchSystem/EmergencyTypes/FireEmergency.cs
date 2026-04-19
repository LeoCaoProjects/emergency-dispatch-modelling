using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.EmergencyTypes
{
    public class FireEmergency : EmergencyType
    {
        private string hazardLevel;
        private bool requiresEvacuation;

        public FireEmergency(string hazardLevel, bool requiresEvacuation)
            : base("FIRE", "Fire Emergency")
        {
            this.hazardLevel = hazardLevel;
            this.requiresEvacuation = requiresEvacuation;
        }

        public string HazardLevel
        {
            get { return hazardLevel; }
            set { hazardLevel = value; }
        }

        public bool RequiresEvacuation
        {
            get { return requiresEvacuation; }
            set { requiresEvacuation = value; }
        }

        public override string getTypeDetails()
        {
            return "";
        }

        public string getHazardLevel()
        {
            return "";
        }
    }
}
