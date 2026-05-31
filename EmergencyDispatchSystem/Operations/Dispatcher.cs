using System;
using EmergencyDispatchSystem.Core;
using EmergencyDispatchSystem.Units;

namespace EmergencyDispatchSystem.Operations
{

    // This is the Observer interface where concrete observers that implement this
    // will get notified with onReinforcementRequested
    public interface IReinforcementObserver
    {
        void onReinforcementRequested(RespondingUnit unit);
    }


    public class Dispatcher : IReinforcementObserver
    {
        private string dispatcherId;
        private string name;
        private FleetManager fleet = FleetManager.GetInstance();

        public Dispatcher(string dispatcherId, string name)
        {
            this.dispatcherId = dispatcherId;
            this.name = name;
        }

        public void onReinforcementRequested(RespondingUnit unit)
        {
            if (unit is PoliceUnit)
            {
                dispatchSupportUnit(new PoliceUnit(""));
            }
            else if (unit is FireUnit)
            {
                dispatchSupportUnit(new FireUnit(""));
            }
        }

        private void dispatchSupportUnit(RespondingUnit u)
        {
            Console.WriteLine("[DISPATCHER " + dispatcherId + "] Support unit " + u.UnitId + " dispatched.");
            if (u is IReinforcementSubject subject)
            {
                subject.attach(this);
            }
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
    }
}
