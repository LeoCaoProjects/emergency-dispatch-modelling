using System;

namespace EmergencyDispatchSystem.EmergencyTypes
{
    // This is the factory class; it declares the factory methods.
    abstract class EmergencyCreator
    {
        // This is the factory method that the subclasses needs to implement.
        // It returns a specific product instance.
        public abstract EmergencyType createEmergency();

    }

    // CONCRETE CREATOR CLASSES:

    // FireEmergencyCreator overrides the factory method to return a FireEmergency instance.
    class FireEmergencyCreator : EmergencyCreator
    {
        public override EmergencyType createEmergency()
        {
            return new FireEmergency();
        }
    }

    // PoliceEmergencyCreator overrides the factory method to return a PoliceEmergency instance.
    class PoliceEmergencyCreator : EmergencyCreator
    {
        public override EmergencyType createEmergency()
        {
            return new PoliceEmergency();
        }
    }

    // MedicalEmergencyCreator overrides the factory method to return a MedicalEmergency instance.
    class MedicalEmergencyCreator : EmergencyCreator
    {
        public override EmergencyType createEmergency()
        {
            return new MedicalEmergency();
        }
    }

}