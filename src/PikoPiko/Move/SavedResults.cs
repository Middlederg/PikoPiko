using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class SavedResults
    {
        private readonly List<IResult> savedResults;
        public IEnumerable<RollEntry> GetRollEntries => savedResults.ToRollEntries().ToList();
        public void AddResults(IEnumerable<IResult> results)
        {
            if (results.Distinct().Count() != 1)
                throw new SavingResultException();

            savedResults.AddRange(results);
        }

        public bool ContainsWorm => savedResults.Contains(ResultFactory.Worm);

        public int Points
        {
            get
            {
                if (!savedResults.Any() || !ContainsWorm)
                    return 0;

                return VirtualPoints;
            }
        }

        public int VirtualPoints => savedResults.Sum(x => x.Value);

        public int DicesRemaining => DiceRoll.StartingDiceCount - savedResults.Count;

        public SavedResults()
        {
            savedResults = new List<IResult>();
        }

        public bool CanBeSaved(IResult result) => !savedResults.Any(x => x.Equals(result));

        public override string ToString() => string.Join(", ", savedResults.ToRollEntries());
    }
}
