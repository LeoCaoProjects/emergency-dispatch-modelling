using System;
using EmergencyDispatchSystem.Core;
using EmergencyDispatchSystem.Operations;

namespace EmergencyDispatchSystem.Units
{
    public class PoliceUnit : RespondingUnit
    {
        private string division;
        private Dispatcher dispatcher;

        public PoliceUnit(string unitId, string location, string division, Dispatcher dispatcher)
            : base(unitId, location)
        {
            this.division = division;
            this.dispatcher = dispatcher;
        }

        public string Division
        {
            get { return division; }
            set { division = value; }
        }

        public Dispatcher Dispatcher
        {
            get { return dispatcher; }
            set { dispatcher = value; }
        }

        public void requestReinforcements()
        {
            Console.WriteLine("[" + UnitId + "] Requesting reinforcements through Dispatcher.");
        }
    }
}