using System.Linq;
using Xunit;

namespace PikoPiko.Test
{
    public class PlayMoveTests
    {
        [Fact]
        public void Can_not_Save_previously_saved_results()
        {
            var move = new PlayMove();
            var firstResult = move.CurrentRoll.GetAllResults().First();

            move.Save(firstResult);

            do
            {
                move.Roll();
            }
            while (!move.CurrentRoll.Has(firstResult));

            var canBeSaved = move.CanSave(firstResult);
            
            Assert.False(canBeSaved);
            Assert.Throws<SavingResultException>(() => move.Save(firstResult));
        }

        [Fact]
        public void Should_continue_playing()
        {
            var move = new PlayMove();

            var highestFirst = move.CurrentRoll.Higest().Result;
            move.Save(highestFirst);
            move.Roll();
            var highestSecond = move.CurrentRoll.Higest();
            
            if (highestSecond != null)
            {
                var canKeepGoing = move.CanKeepRolling();
                Assert.True(canKeepGoing);
            }
        }

        [Fact]
        public void Should_not_continue_playing()
        {
            var move = new PlayMove();

            SaveIfPosible(move, ResultFactory.One);
            SaveIfPosible(move, ResultFactory.Two);
            SaveIfPosible(move, ResultFactory.Three);
            SaveIfPosible(move, ResultFactory.Four);
            SaveIfPosible(move, ResultFactory.Five);
            SaveIfPosible(move, ResultFactory.Worm);
            var canKeepGoing = move.CanKeepRolling();

            Assert.False(canKeepGoing);
        }

        private void SaveIfPosible(PlayMove move, IResult result)
        {
            if (move.CanSave(result) && move.CurrentRoll.Has(result))
                move.Save(result);
        }
    }
}
