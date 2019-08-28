using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class PlayMove
    {
        private readonly SavedResults savedResults;
        public bool HasWormSaved => savedResults.ContainsWorm;

        public DiceRoll CurrentRoll { get; private set; }
        public bool HasStoped { get; private set; }
        public void Stop() => HasStoped = true;
        public int Points
        {
            get
            {
                if (!CanKeepRolling() && !HasStoped)
                    return 0;

                return savedResults.Points;
            }
        }
        public int VirtualPoints => savedResults.VirtualPoints;

        public PlayMove()
        {
            savedResults = new SavedResults();
            CurrentRoll = new DiceRoll();
            HasStoped = false;
        }

        public bool CanSave(IResult result) => savedResults.CanBeSaved(result);
        public int WhatIf(IResult result)
        {
            var count = CurrentRoll.ResultCount(result);
            return VirtualPoints + (result.Value * count);
        }

        public void Save(IResult result)
        {
            if (!CanSave(result))
                throw new SavingResultException(result, savedResults);

            var results = CurrentRoll.GetResultsOfType(result).ToList();
            savedResults.AddResults(results);
        }

        public void Roll()
        {
            CurrentRoll = new DiceRoll(savedResults.DicesRemaining);
        }

        public IResult BestOption()
        {
            return CurrentRoll.GetAllDisctinctResults()
                .Where(result => savedResults.CanBeSaved(result))
                .ToRollEntries()
                .OrderByDescending(x => x.Points())
                .Select(x => x.Result)
                .FirstOrDefault();
        }

        public bool IsFailure(int objetive) => Points < objetive;

        public bool CanKeepRolling() => CurrentRoll.GetAllDisctinctResults().Any(result => savedResults.CanBeSaved(result));

        public IEnumerable<RollEntry> GetSavedRollEntries => savedResults.GetRollEntries;
    }
}
