using System;
using System.Collections.Generic;
using EmergencyDispatchSystem.Units;

namespace EmergencyDispatchSystem.Operations
{
    public class AmbulanceFleet
    {
        private string fleetId;
        private List<AmbulanceUnit> units;

        public AmbulanceFleet(string fleetId)
        {
            this.fleetId = fleetId;
            this.units = new List<AmbulanceUnit>();
        }

        public string FleetId
        {
            get { return fleetId; }
        }

        public List<AmbulanceUnit> Units
        {
            get { return units; }
        }

        public List<AmbulanceUnit> getAvailableUnits()
        {
            return new List<AmbulanceUnit>();
        }

        public void returnUnitToAvailable(string id)
        {
        }

        public void updateUnitStatus(string id, string s)
        {
        }
    }
}
