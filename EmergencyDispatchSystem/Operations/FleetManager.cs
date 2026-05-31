using System;
using System.Collections.Generic;
using EmergencyDispatchSystem.Core;
using EmergencyDispatchSystem.Units;

namespace EmergencyDispatchSystem.Operations
{
    public class FleetManager
    {
        // List of all ambulence units this class handles
        private List<AmbulanceUnit> units;                      

        // Static variable that stores the single instance of the class
        private static FleetManager instance;

        // Private constructor prevents object creation using 'new'
        private FleetManager()
        {
            this.units = new List<AmbulanceUnit>();
        }

        // Public static method provides global access to the Singleton object
        public static FleetManager GetInstance() 
        {
            // Create the object only if it does not already exist
            if (instance == null)
            {
                instance = new FleetManager();
            }

            // return the same object instance.
            return instance;
        }



        public void addUnit(AmbulanceUnit u)
        {
            units.Add(u);
        }

        public AmbulanceUnit getAvailableUnit()
        {
            return units.Find(u => u.isAvailable());
        }
    }
}
