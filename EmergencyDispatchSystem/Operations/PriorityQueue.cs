using System;
using System.Collections.Generic;
using EmergencyDispatchSystem.Core;

namespace EmergencyDispatchSystem.Operations
{
    public class PriorityQueue
    {
        private List<EmergencyCase> cases;

        public PriorityQueue()
        {
            this.cases = new List<EmergencyCase>();
        }

        public List<EmergencyCase> Cases
        {
            get { return cases; }
        }

        // Add the case to the queue
        public void enqueue(EmergencyCase c)
        {
            cases.Add(c);
            Console.WriteLine("[QUEUE] Case " + c.CaseId + " enqueued (Severity: " + c.SeverityLevel + ").");
        }

        // Remove a case from the queue (front of the queue)
        public EmergencyCase dequeue()
        {
            if (isEmpty()) return null;
            EmergencyCase c = cases[0];
            cases.RemoveAt(0);
            Console.WriteLine("[QUEUE] Case " + c.CaseId + " dequeued for dispatch.");
            return c;
        }

        public void sortBySeverity()
        {
        }

        public bool isEmpty()
        {
            return cases.Count == 0;
        }
    }
}