using System.Linq;
using Xunit;

namespace PikoPiko.Test
{
    public class CompleteGameTests
    {
        private void PlayGameTakingOnlyRations(GameContext game)
        {

            do
            {
                int number;
                do
                {
                    number = ResultFactory.GetRandomNumber(21, 36);
                }
                while (!game.IsSuccess(number));

                game.TakeRation(number);
            }
            while (!game.IsEndOfGame());
        }

        [Fact]
        public void Should_play_until_end()
        {
            var game = new GameContext(2);

            PlayGameTakingOnlyRations(game);

            var winner = game.Winner();
            var ranking = game.Ranking();

            Assert.True(winner.Worms() == ranking.First().Worms());
            Assert.True(winner.Worms() >= ranking.Last().Worms());
        }
    }
}
