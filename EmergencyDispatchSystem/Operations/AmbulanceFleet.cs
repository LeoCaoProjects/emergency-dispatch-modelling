using System;
using System.Collections.Generic;
using EmergencyDispatchSystem.Core;
using EmergencyDispatchSystem.Units;

namespace EmergencyDispatchSystem.Operations
{
    public class AmbulanceFleet
    {
        private string fleetId;
        private List<AmbulanceUnit> units;                      // List of all ambulence units this class handles

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

        // Find the ambulence unit and return it to avaliable status (when it completes the case)
        public void returnUnitToAvailable(string id)
        {
            AmbulanceUnit u = units.Find(u => u.UnitId == id);
            if (u != null)
            {
                u.setStatus(UnitStatus.Available);
                Console.WriteLine("[FLEET] Unit " + id + " returned to Available.");
            }
        }

        // Update the status of the ambulence
        public void updateUnitStatus(string id, UnitStatus s)
        {
            AmbulanceUnit u = units.Find(u => u.UnitId == id);
            if (u != null) u.setStatus(s);
        }
    }
}