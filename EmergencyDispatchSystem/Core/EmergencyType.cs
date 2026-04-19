using System;

namespace EmergencyDispatchSystem.Core
{
    public abstract class EmergencyType
    {
        private string typeId;
        private string description;

        protected EmergencyType(string typeId, string description)
        {
            this.typeId = typeId;
            this.description = description;
        }

        public string TypeId
        {
            get { return typeId; }
            protected set { typeId = value; }
        }

        public string Description
        {
            get { return description; }
            protected set { description = value; }
        }

        public abstract string getTypeDetails();
    }
}
