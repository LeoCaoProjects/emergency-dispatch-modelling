using System;

namespace EmergencyDispatchSystem.EmergencyTypes
{

    // This is the product interface that defins
    // all operations the concrete products must implement

    public interface IEmergencyType
    {
        public abstract string getEmergencyTypeDetails();
    }


    // CONCRETE PRODUCTS:


    // FireEmergency provides a specific implementation of the IEmergencyType interface.
    public class FireEmergency : IEmergencyType
    {
        private string typeId = "FIRE";
        private string hazardLevel;
        private bool requiresEvacuation;


        public FireEmergency(string hazardLevel, bool requiresEvacuation)
        {
            this.hazardLevel = hazardLevel;
            this.requiresEvacuation = requiresEvacuation;
        }

        public override string getTypeDetails()
        {
            return "(Fire) Hazard Level: " + hazardLevel + ", Evacuation Required: " + requiresEvacuation;
        }
    }


    // PoliceEmergency provides a specific implementation of the IEmergencyType interface.
    public class PoliceEmergency : IEmergencyType
    {
        private string typeId = "POLICE";
        private string threatLevel;
        private bool suspectPresent;

        public PoliceEmergency(string threatLevel, bool suspectPresent)
        {
            this.threatLevel = threatLevel;
            this.suspectPresent = suspectPresent;
        }

        public override string getTypeDetails()
        {
            return "(Police) Threat Level: " + threatLevel + ", Suspect Present: " + suspectPresent;
        }
    }


    // MedicalEmergency provides a specific implementation of the IEmergencyType interface.
    public class MedicalEmergency : IEmergencyType
    {
        private string typeId = "MEDICAL";
        private string patientCondition;
        private bool requiresTransport;

        public MedicalEmergency(string patientCondition, bool requiresTransport)
        {
            this.patientCondition = patientCondition;
            this.requiresTransport = requiresTransport;
        }


        public override string getTypeDetails()
        {
            return "(Medical) Condition: " + patientCondition + ", Transport Required: " + requiresTransport;
        }

    }
}