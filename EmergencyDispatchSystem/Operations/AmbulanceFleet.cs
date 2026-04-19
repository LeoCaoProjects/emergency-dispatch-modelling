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

        public void addUnit(AmbulanceUnit u)
        {
            units.Add(u);
        }

        public List<AmbulanceUnit> getAvailableUnits()
        {
            return units.FindAll(u => u.isAvailable());
        }

        public void returnUnitToAvailable(string id)
        {
            AmbulanceUnit u = units.Find(u => u.UnitId == id);
            if (u != null)
            {
                u.setStatus("Available");
                Console.WriteLine("[FLEET] Unit " + id + " returned to Available.");
            }
        }

        public void updateUnitStatus(string id, string s)
        {
            AmbulanceUnit u = units.Find(u => u.UnitId == id);
            if (u != null) u.setStatus(s);
        }
    }
}