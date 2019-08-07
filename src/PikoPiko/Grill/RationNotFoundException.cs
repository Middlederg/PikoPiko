using System;

namespace PikoPiko
{
    [Serializable]
    public class RationNotFoundException : Exception
    {
        public RationNotFoundException(int value) : base($"Ration with value {value} was not found") { }
        public RationNotFoundException() : base($"No ration was found") { }
    }
}
