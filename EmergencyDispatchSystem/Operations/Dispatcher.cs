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

        public void assignUnit(RespondingUnit u, EmergencyCase c)
        {
        }

        public void reassignUnit(RespondingUnit u, EmergencyCase c)
        {
        }

        public void dispatchSupportUnit(RespondingUnit u)
        {
        }

        public void alertCriticalCase(EmergencyCase c)
        {
        }
    }
}
