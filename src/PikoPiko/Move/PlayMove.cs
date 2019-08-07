using System.Collections.Generic;
using System.Linq;

namespace PikoPiko
{
    public class PlayMove
    {
        private List<IResult> savedResults;
        public DiceRoll CurrentRoll { get; private set; }

        public PlayMove()
        {
            savedResults = new List<IResult>();
            CurrentRoll = new DiceRoll();
        }

        public bool CanSave(IResult result) => !savedResults.Any(x => x.Equals(result));

        public void Save(IResult result)
        {
            if (!CanSave(result))
                throw new SavingResultException(result, savedResults);

            savedResults.AddRange(CurrentRoll.GetResults(result));
        }

        public void Roll()
        {
            CurrentRoll = new DiceRoll(DiceRoll.StartingDiceCount - savedResults.Count);
        }
    }
}
