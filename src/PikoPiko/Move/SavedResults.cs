using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class SavedResults
    {
        private List<IResult> savedResults;
        public void AddResults(IEnumerable<IResult> results)
        {
            if (results.Distinct().Count() != 1)
                throw new SavingResultException();

            savedResults.AddRange(results);
        }

        public int Points
        {
            get
            {
                if (!savedResults.Any() || !savedResults.Contains(ResultFactory.Worm))
                    return 0;

                return savedResults.Sum(x => x.Value);
            }
        }

        public int DicesRemaining => DiceRoll.StartingDiceCount - savedResults.Count;

        public SavedResults()
        {
            savedResults = new List<IResult>();
        }

        public bool CanBeSaved(IResult result) => !savedResults.Any(x => x.Equals(result));

        public override string ToString() => string.Join(", ", savedResults.ToRollEntries());
    }
}
