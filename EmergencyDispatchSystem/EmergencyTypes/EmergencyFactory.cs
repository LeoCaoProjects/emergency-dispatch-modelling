using System;

namespace EmergencyDispatchSystem.EmergencyTypes
{
    // This is the factory class; it declares the factory methods.
    public abstract class EmergencyCreator
    {
        // This is the factory method that the subclasses needs to implement.
        // It returns a specific product instance.
        public abstract IEmergencyType createEmergency();

    }

    // CONCRETE CREATOR CLASSES:

    // FireEmergencyCreator overrides the factory method to return a FireEmergency instance.
    class FireEmergencyCreator : EmergencyCreator
    {
        public override IEmergencyType createEmergency()
        {
            return new FireEmergency("High", true);
        }
    }

    // PoliceEmergencyCreator overrides the factory method to return a PoliceEmergency instance.
    class PoliceEmergencyCreator : EmergencyCreator
    {
        public override IEmergencyType createEmergency()
        {
            return new PoliceEmergency("High", true);
        }
    }

    // MedicalEmergencyCreator overrides the factory method to return a MedicalEmergency instance.
    class MedicalEmergencyCreator : EmergencyCreator
    {
        public override IEmergencyType createEmergency()
        {
            return new MedicalEmergency("", true);
        }
    }

}