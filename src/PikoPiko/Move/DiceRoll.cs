using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class DiceRoll
    {
        public const int StartingDiceCount = 8;
        private readonly IEnumerable<IResult> results;
        public bool Has(IResult result) => results.Any(x => x.Equals(result));

        public DiceRoll(int diceCount = StartingDiceCount)
        {
            results = Enumerable.Range(0, diceCount).Select(x => ResultFactory.Any).ToList();
        }

        public int WormCount => results.Count(result => result.IsWorm);
        public IEnumerable<IResult> GetResults(IResult resultType) => results.Where(result => result.Equals(resultType));

        public IEnumerable<IResult> GetAllResults() => results
            .Distinct()
            .OrderBy(result => result.IsWorm)
            .ThenBy(result => result.Value)
            .ToList();

        public RollEntry Higest()
        {
            var entries = RollEntries();

            if (!entries.Any())
                return null;

            int points = entries.Max(x => x.Points());
            return entries.First(x => x.Points() == points);
        }

        private IEnumerable<RollEntry> RollEntries() => results.ToRollEntries().ToList();
        
    }
}
