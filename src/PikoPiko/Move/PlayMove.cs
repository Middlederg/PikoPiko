using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class PlayMove
    {
        private SavedResults savedResults;
        public DiceRoll CurrentRoll { get; private set; }
        public int Points
        {
            get
            {
                if (!CanKeepRolling())
                    return 0;

                return savedResults.Points;
            }
        }

        public PlayMove()
        {
            savedResults = new SavedResults();
            CurrentRoll = new DiceRoll();
        }

        public bool CanSave(IResult result) => savedResults.CanBeSaved(result);

        public void Save(IResult result)
        {
            if (!CanSave(result))
                throw new SavingResultException(result, savedResults);

            var results = CurrentRoll.GetResults(result).ToList();
            savedResults.AddResults(results);
        }

        public void Roll()
        {
            CurrentRoll = new DiceRoll(savedResults.DicesRemaining);
        }

        public IResult BestOption()
        {
            return CurrentRoll.GetAllResults()
                .Where(result => savedResults.CanBeSaved(result))
                .ToRollEntries()
                .OrderByDescending(x => x.Points())
                .Select(x => x.Result)
                .FirstOrDefault();
        }

        public bool IsFailure(int objetive) => Points < objetive;

        public bool CanKeepRolling() => CurrentRoll.GetAllResults().Any(result => savedResults.CanBeSaved(result));
    }
}
