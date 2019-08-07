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
            results = Enumerable.Range(0, diceCount).Select(x => ResultFactory.GetRandomResult()).ToList();
        }

        public IEnumerable<IResult> GetResults(IResult resultType) => results.Where(x => x.Equals(resultType));
        public IEnumerable<IResult> GetAllResults() => results.Distinct().OrderBy(x => x.IsWorm).ThenBy(x => x.Value).ToList();

        public RollEntry Higest()
        {
            var entries = RollEntries();
            int points = entries.Max(x => x.Points());
            return entries.First(x => x.Points() == points);
        }

        private IEnumerable<RollEntry> RollEntries()
        {
            foreach (var result in GetAllResults())
            {
                int quantity = results.Count(x => x.Equals(result));
                yield return new RollEntry(result, quantity);
            }
        }
    }

    public class RollEntry
    {
        public IResult Result { get; }
        public int Quantity { get; }

        public RollEntry(IResult result, int quantity)
        {
            Result = result;
            this.Quantity = quantity;
        }

        public int Points() => Result.Value * Quantity;
    }
}
