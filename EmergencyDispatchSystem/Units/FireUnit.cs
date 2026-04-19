using System;
using EmergencyDispatchSystem.Core;
using EmergencyDispatchSystem.Operations;

namespace EmergencyDispatchSystem.Units
{
    public class FireUnit : RespondingUnit
    {
        private string stationId;
        private Dispatcher dispatcher;

        public FireUnit(string unitId, string location, string stationId, Dispatcher dispatcher)
            : base(unitId, location)
        {
            this.stationId = stationId;
            this.dispatcher = dispatcher;
        }

        public string StationId
        {
            get { return stationId; }
            set { stationId = value; }
        }

        public Dispatcher Dispatcher
        {
            get { return dispatcher; }
            set { dispatcher = value; }
        }

        public void requestReinforcements()
        {
        }
    }
}
