using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public static class RationFactory
    {
        public const int RationCount = 16;
        public static IEnumerable<Ration> GetRations()
        {
            foreach (var number in Enumerable.Range(21, RationCount))
            {
                yield return new Ration(number, ((number - RationCount - 1) / 4));
            }
        }
    }
}
