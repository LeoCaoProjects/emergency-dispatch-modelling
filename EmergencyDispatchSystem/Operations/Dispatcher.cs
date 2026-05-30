using System;
using EmergencyDispatchSystem.Core;
using EmergencyDispatchSystem.Units;

namespace EmergencyDispatchSystem.Operations
{
    public class Dispatcher
    {
        private string dispatcherId;
        private string name;
        private AmbulanceFleet fleet;

        public Dispatcher(string dispatcherId, string name, AmbulanceFleet fleet)
        {
            this.dispatcherId = dispatcherId;
            this.name = name;
            this.fleet = fleet;
        }

        public string DispatcherId
        {
            get { return dispatcherId; }
        }

        public string Name
        {
            get { return name; }
        }

        // Assign a unit to the case
        public void assignUnit(EmergencyCase c)
        {
            AmbulanceUnit unit = fleet.getAvailableUnit();
            c.addUnit(unit);
            unit.updateStatus(UnitStatus.EnRoute);
            Console.WriteLine("[DISPATCHER " + dispatcherId + "] " + unit.UnitId + " assigned to Case " + c.CaseId + ".");
        }

        // Reassign a uni to a didference case
        public void reassignUnit(EmergencyCase c)
        {
            AmbulanceUnit unit = fleet.getAvailableUnit();
            c.addUnit(unit);
            unit.updateStatus(UnitStatus.EnRoute);
            Console.WriteLine("[DISPATCHER " + dispatcherId + "] " + unit.UnitId + " reassigned to Case " + c.CaseId + ".");
        }

        // dispatch extra support units
        public void dispatchSupportUnit(RespondingUnit u)
        {
            u.setStatus(UnitStatus.EnRoute);
            Console.WriteLine("[DISPATCHER " + dispatcherId + "] Support unit " + u.UnitId + " dispatched.");
        }
    }
}
