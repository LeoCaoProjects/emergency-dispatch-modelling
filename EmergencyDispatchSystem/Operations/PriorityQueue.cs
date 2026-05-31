using System;
using System.Collections.Generic;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.Operations
{
    public sealed class PriorityQueue
    {
        private List<EmergencyCase> cases;

        // Static variable that stores the single instance of the class
        // Lazy<T> keeps it thread safe and only creates the object when it is first needed
        private static readonly Lazy<PriorityQueue> instance =
            new Lazy<PriorityQueue>(() => new PriorityQueue());

        // Private constructor prevents object creation using 'new'
        private PriorityQueue()
        {
            this.cases = new List<EmergencyCase>();
        }

        // Public static method provides global access to the Singleton object
        public static PriorityQueue GetInstance()
        {
            return instance.Value;
        }


        public List<EmergencyCase> Cases
        {
            get { return cases; }
        }

        // Add the case to the queue
        public void enqueue(EmergencyCase c)
        {
            cases.Add(c);
            sortBySeverity();
            Console.WriteLine("[QUEUE] Case " + c.CaseId + " enqueued (Severity: " + c.SeverityLevel + ").");
        }

        // Remove a case from the queue (front of the queue)
        public EmergencyCase dequeue()
        {
            if (isEmpty()) return null;
            // Re-sort first so the most severe case is returned
            sortBySeverity();
            EmergencyCase c = cases[0];
            cases.RemoveAt(0);
            Console.WriteLine("[QUEUE] Case " + c.CaseId + " dequeued for dispatch.");
            return c;
        }

        // Hand every queued case to the dispatcher, highest severity first
        public void dispatchAll(Dispatcher dispatcher)
        {
            while (!isEmpty())
            {
                EmergencyCase c = dequeue();
                dispatcher.assignUnit(c);
            }
        }

        // Order the cases so the highest severity (Critical) sits at the front of the queue
        private void sortBySeverity()
        {
            cases.Sort((a, b) => b.SeverityLevel.CompareTo(a.SeverityLevel));
        }

        public bool isEmpty()
        {
            return cases.Count == 0;
        }
    }
}