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

            // Setup 
            AmbulanceFleet fleet = new AmbulanceFleet("FLEET-01");
            AmbulanceUnit ambulance = new AmbulanceUnit("AMB-01", "", 2, "");
            fleet.addUnit(ambulance);
            Dispatcher dispatcher = new Dispatcher("D-01", "Leo", fleet);
            PriorityQueue queue = PriorityQueue.GetInstance();
            CallCentreOperator cco = new CallCentreOperator("CCO-01", "James");

            // The call centre operator logs a call onto the system
            Console.WriteLine("(call centre operator logs emergency call)");
            EmergencyCase ec = cco.logEmergencyCall(new MedicalEmergencyCreator());
            cco.assignSeverityLevel(ec);

            // Dispatcher assigns a unit to a case in the queue
            Console.WriteLine("\n(Dispatcher assigns unit to the case)");
            EmergencyCase active = queue.dequeue();
            dispatcher.assignUnit(active);

            // The assigned ambulance unit arrives on scene of the case
            Console.WriteLine("\n(Ambulance on scene)");
            ambulance.updateStatus(UnitStatus.OnScene);

            // Issue has been flagged on scene, requesting for police to be dispatched
            Console.WriteLine("\n(Issue flagged, police dispatched)");
            ambulance.flagIssue("police support required.");
            PoliceUnit police = new PoliceUnit("POL-01", "", "", dispatcher);
            dispatcher.dispatchSupportUnit(police);

            // Police requests even more reinforcements
            Console.WriteLine("\n(Police requests reinforcements)");
            police.requestReinforcements();

            // Step 7: The case has been completed
            Console.WriteLine("\n(Case completed)");
            active.setStatus(CaseStatus.Resolved);
            IncidentReport report = new IncidentReport();
            report.generateReport(active);
            ambulance.updateStatus(UnitStatus.Available);
        }
    }
}
