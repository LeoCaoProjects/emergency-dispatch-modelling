using System;

namespace EmergencyDispatchSystem.Units
{

    // Subject interface where concrete subjects that implement this interface
    // can add and remove observers and notify them.
    public interface IReinforcementSubject
    {
        void attach(IReinforcementObserver observer);
        void detach(IReinforcementObserver observer);
        void requestReinforcements();
    }




    // Concrete responding unit classes

    public class FireUnit : RespondingUnit, IReinforcementSubject
    {
        private string stationId;
        // List of observers this unit will notify
        private readonly List<IReinforcementObserver> observers = new List<IReinforcementObserver>();

        public FireUnit(string unitId, string stationId)
            : base(unitId)
        {
            this.stationId = stationId;
            this.dispatcher = dispatcher;
        }

        void attach(IReinforcementObserver observer) {
            if(!observers.Contains(observer)) {
                observers.add(observer);
            }
        }

        void detach(IReinforcementObserver observer) {
            observers.remove(observer);
        }

        // This will notify all of the observers
        public void requestReinforcements() {
            foreach (var observer in observers) {
                observer.onReinforcementRequested(this);
            }
        }
    }

    public class PoliceUnit : RespondingUnit, IReinforcementSubject
    {
        private string division;
        // List of observers this unit will notify
        private readonly List<IReinforcementObserver> observers = new List<IReinforcementObserver>();

        public PoliceUnit(string unitId, string division)
            : base(unitId)
        {
            this.division = division;
            this.dispatcher = dispatcher;
        }

        void attach(IReinforcementObserver observer) {
            if(!observers.Contains(observer)) {
                observers.add(observer);
            }
        }

        void detach(IReinforcementObserver observer) {
            observers.remove(observer);
        }

        // This will notify all of the observers
        public void requestReinforcements() {
            foreach (var observer in observers) {
                observer.onReinforcementRequested(this);
            }
        }
    }
}
