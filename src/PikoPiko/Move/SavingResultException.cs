using System;
using System.Collections.Generic;

namespace PikoPiko
{
    [Serializable]
    public class SavingResultException : Exception
    {
        public SavingResultException(IResult result) : base($"Unable to save result {result.ToString()}") { }
        public SavingResultException(IResult result, IEnumerable<IResult> savedResults) 
            : base($"Unable to save result {result.ToString()}. Saved results: {savedResults}") { }
    }
}
