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

        public void enqueue(EmergencyCase c)
        {
        }

        public EmergencyCase dequeue()
        {
            return null;
        }

        public void sortBySeverity()
        {
        }

        public bool isEmpty()
        {
            return false;
        }
    }
}
