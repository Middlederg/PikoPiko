using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public static class RationFactory
    {
        public const int RationCount = 16;
        public const int RationFirstValue = 21;
        public static IEnumerable<Ration> GetRations()
        {
            foreach (var number in Enumerable.Range(RationFirstValue, RationCount))
            {
                yield return new Ration(number, ((number - RationCount - 1) / 4));
            }
        }
    }
}
