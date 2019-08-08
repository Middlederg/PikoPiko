using System.Collections.Generic;
using Xunit;

namespace PikoPiko.Test
{
    public class SavedResultsTests
    {
        [Fact]
        public void Should_save_any_result_only_once()
        {
            var savedResults = new SavedResults();
            var anyResult = ResultFactory.Any;

            var canBeSavedBefore = savedResults.CanBeSaved(anyResult);
            savedResults.AddResults(new List<IResult>() { anyResult });
            var canBeSavedAfter = savedResults.CanBeSaved(anyResult);
            var diceRemaining = savedResults.DicesRemaining;

            Assert.True(canBeSavedBefore);
            Assert.False(canBeSavedAfter);
            Assert.Equal(DiceRoll.StartingDiceCount - 1, diceRemaining);
        }

        [Fact]
        public void Check_value_after_adding_a_worm()
        {
            var savedResults = new SavedResults();
            var worm = ResultFactory.Worm;

            savedResults.AddResults(new List<IResult>() { worm });

            Assert.Equal(WormResult.WormDefaultValue, savedResults.Points);
        }
    }
}
