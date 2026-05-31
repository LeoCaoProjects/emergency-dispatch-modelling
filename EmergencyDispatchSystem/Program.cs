using System;
using EmergencyDispatchSystem.Core;
using EmergencyDispatchSystem.EmergencyTypes;
using EmergencyDispatchSystem.Units;
using EmergencyDispatchSystem.Operations;
using EmergencyDispatchSystem.Logging;

namespace EmergencyDispatchSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Emergency Dispatch System Demo\n");

            // ---------- SINGLETON ----------
            // The fleet and the queue both hand back one shared instance through GetInstance()
            Console.WriteLine("--- Singleton ---");
            FleetManager fleet = FleetManager.GetInstance();
            PriorityQueue queue = PriorityQueue.GetInstance();

            // Asking for the instance again returns the exact same object
            Console.WriteLine("Same fleet instance? " + (fleet == FleetManager.GetInstance()));
            Console.WriteLine("Same queue instance? " + (queue == PriorityQueue.GetInstance()));

            // Add a few ambulances to the one shared fleet
            AmbulanceUnit ambulance = new AmbulanceUnit(2, "");
            fleet.addUnit(ambulance);
            fleet.addUnit(new AmbulanceUnit(2, ""));
            fleet.addUnit(new AmbulanceUnit(2, ""));

            Dispatcher dispatcher = new Dispatcher("D-01", "Leo");
            CallCentreOperator cco = new CallCentreOperator("CCO-01", "James");

            // ---------- FACTORY METHOD ----------
            // The operator logs different emergency types without calling new FireEmergency(),
            // each creator builds its own product behind the IEmergencyType interface
            Console.WriteLine("\n--- Factory Method ---");
            EmergencyCase medicalCase = cco.logEmergencyCall(new MedicalEmergencyCreator());
            EmergencyCase fireCase = cco.logEmergencyCall(new FireEmergencyCreator());
            EmergencyCase policeCase = cco.logEmergencyCall(new PoliceEmergencyCreator());

            // The details come from each concrete types own getEmergencyTypeDetails()
            Console.WriteLine(medicalCase.Type.getEmergencyTypeDetails());
            Console.WriteLine(fireCase.Type.getEmergencyTypeDetails());
            Console.WriteLine(policeCase.Type.getEmergencyTypeDetails());

            // ---------- PRIORITY QUEUE ----------
            // The operator applies each call with a severity, the queue keeps the most severe at the front
            Console.WriteLine("\n--- Priority Queue ---");
            medicalCase.SeverityLevel = SeverityLevel.Medium;
            fireCase.SeverityLevel = SeverityLevel.Critical;
            policeCase.SeverityLevel = SeverityLevel.High;

            // Cases are dispatched highest severity first, not in the order they were logged
            Console.WriteLine("\n(Dispatcher assigns units in priority order)");
            queue.dispatchAll(dispatcher);

            // ---------- OBSERVER ----------
            // On scene issue: the police unit becomes a subject and the dispatcher observes it
            Console.WriteLine("\n--- Observer ---");
            ambulance.updateStatus(UnitStatus.OnScene);
            ambulance.flagIssue("police support required.");
            PoliceUnit police = new PoliceUnit("");
            police.attach(dispatcher);

            // The unit notifies its observers, and the dispatcher reacts by dispatching support
            Console.WriteLine("\n(Police requests reinforcements)");
            police.requestReinforcements();

            // The most severe case has been completed
            Console.WriteLine("\n(Case completed)");
            fireCase.setStatus(CaseStatus.Resolved);
            IncidentReport report = new IncidentReport();
            report.generateReport(fireCase);
            ambulance.updateStatus(UnitStatus.Available);
        }
    }
}
