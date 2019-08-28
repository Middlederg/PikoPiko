using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class DiceRoll
    {
        public const int StartingDiceCount = 8;
        public IEnumerable<IResult> Results { get; }
        public bool Has(IResult result) => Results.Any(x => x.Equals(result));

        public DiceRoll(int diceCount = StartingDiceCount)
        {
            Results = Enumerable.Range(0, diceCount).Select(x => ResultFactory.Any).ToList();
        }

        public int WormCount => Results.Count(result => result.IsWorm);
        public int ResultCount(IResult result) => Results.Count(r => r.Equals(result));
        public IEnumerable<IResult> GetResultsOfType(IResult resultType) => Results.Where(result => result.Equals(resultType));

        public IEnumerable<IResult> GetAllDisctinctResults() => Results
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

        private IEnumerable<RollEntry> RollEntries() => Results.ToRollEntries().ToList();
        
    }
}
