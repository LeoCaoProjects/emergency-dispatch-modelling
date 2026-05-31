using System;
using EmergencyDispatchSystem.Operations;

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

        public FireUnit(string stationId)
            : base()
        {
            this.stationId = stationId;
            this.dispatcher = dispatcher;
        }

        public void attach(IReinforcementObserver observer) {
            if(!observers.Contains(observer)) {
                observers.add(observer);
            }
        }

        public void detach(IReinforcementObserver observer) {
            observers.remove(observer);
        }

        // This will notify all of the observers
        public void requestReinforcements() {
            foreach (var observer in observers) {
                Console.WriteLine("[" + UnitId + "] Requesting reinforcements through Dispatcher.");
                observer.onReinforcementRequested(this);
            }
        }
    }

    public class PoliceUnit : RespondingUnit, IReinforcementSubject
    {
        private string division;
        // List of observers this unit will notify
        private readonly List<IReinforcementObserver> observers = new List<IReinforcementObserver>();

        public PoliceUnit(string division)
            : base()
        {
            this.division = division;
            this.dispatcher = dispatcher;
        }

        public void attach(IReinforcementObserver observer) {
            if(!observers.Contains(observer)) {
                observers.add(observer);
            }
        }

        public void detach(IReinforcementObserver observer) {
            observers.remove(observer);
        }

        // This will notify all of the observers
        public void requestReinforcements() {
            foreach (var observer in observers) {
                Console.WriteLine("[" + UnitId + "] Requesting reinforcements through Dispatcher.");
                observer.onReinforcementRequested(this);
            }
        }
    }
}
