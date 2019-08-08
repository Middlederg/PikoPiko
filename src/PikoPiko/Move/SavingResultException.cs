using System;
using System.Collections.Generic;

namespace PikoPiko
{
    [Serializable]
    public class SavingResultException : Exception
    {
        public SavingResultException() : base($"Unable to save result") { }
        public SavingResultException(IResult result) : base($"Unable to save result {result.ToString()}") { }
        public SavingResultException(IResult result, SavedResults savedResults) 
            : base($"Unable to save result {result.ToString()}. Saved results: {savedResults.ToString()}") { }
    }
}
