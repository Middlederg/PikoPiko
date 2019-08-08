using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public static class RollEntryHelper
    {
        public static IEnumerable<RollEntry> ToRollEntries(this IEnumerable<IResult> results)
        {
            foreach (var result in results.Distinct())
            {
                int quantity = results.Count(x => x.Equals(result));
                yield return new RollEntry(result, quantity);
            }
        }
    }
}
