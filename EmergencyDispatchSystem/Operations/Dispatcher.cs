using System;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.Operations
{
    public class Dispatcher
    {
        private string dispatcherId;
        private string name;

        public Dispatcher(string dispatcherId, string name)
        {
            this.dispatcherId = dispatcherId;
            this.name = name;
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
        public void assignUnit(RespondingUnit u, EmergencyCase c)
        {
            u.setStatus("En Route");
            c.addUnit(u);
            Console.WriteLine("[DISPATCHER " + dispatcherId + "] " + u.UnitId + " assigned to Case " + c.CaseId + ".");
        }

        // Reassign a uni to a didference case
        public void reassignUnit(RespondingUnit u, EmergencyCase c)
        {
            u.setStatus("En Route");
            c.addUnit(u);
            Console.WriteLine("[DISPATCHER " + dispatcherId + "] " + u.UnitId + " reassigned to Case " + c.CaseId + ".");
        }

        // dispatch extra support units
        public void dispatchSupportUnit(RespondingUnit u)
        {
            u.setStatus("En Route");
            Console.WriteLine("[DISPATCHER " + dispatcherId + "] Support unit " + u.UnitId + " dispatched.");
        }

        public void alertCriticalCase(EmergencyCase c)
        {
        }
    }
}