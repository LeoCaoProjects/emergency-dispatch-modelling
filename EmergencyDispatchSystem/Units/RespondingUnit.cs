using System;

namespace EmergencyDispatchSystem.Units
{
    public enum UnitStatus
    {
        Available,
        EnRoute,
        OnScene,
        Unavailable
    }

    // Abstract class for the responding units.
    public abstract class RespondingUnit
    {
        private static int nextUnitId = 1;
        private int unitId;

        protected RespondingUnit()
        {
            this.unitId = nextUnitId++;
        }

        public int UnitId
        {
            get { return unitId; }
        }
    }


    // Concrete responding unit class

    public class AmbulanceUnit : RespondingUnit
    {
        private int crewSize;
        private string vehicleType;
        private UnitStatus status;

        public AmbulanceUnit(int crewSize, string vehicleType)
            : base()
        {
            this.crewSize = crewSize;
            this.vehicleType = vehicleType;
            this.status = UnitStatus.Available;
        }

        public bool isAvailable()
        {
            return status == UnitStatus.Available;
        }

        public void updateStatus(UnitStatus status)
        {
            this.status = status;
            Console.WriteLine("[" + UnitId + "] Status updated to: " + status);
        }
    }
}
