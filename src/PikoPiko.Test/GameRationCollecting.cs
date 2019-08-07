using Xunit;

namespace PikoPiko.Test
{
    public class GameRationCollecting
    {
        [Theory]
        [InlineData(14)]
        [InlineData(7)]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        public void Should_be_failed_turn(int number)
        {
            var game = new GameContext(2);
            game.TakeRation(21);
            game.TakeRation(30);
            game.TakeRation(22);
            game.TakeRation(31);

            Assert.False(game.IsSuccess(number));
            Assert.Throws<RationNotFoundException>(() => game.TakeRation(number));
        }

        [Theory]
        [InlineData(23)]
        [InlineData(31)]
        [InlineData(24)]
        [InlineData(34)]
        [InlineData(29)]
        public void Should_be_succesfull_turn(int number)
        {
            var game = new GameContext(2);
            game.TakeRation(21);
            game.TakeRation(30);
            game.TakeRation(22);
            game.TakeRation(31);

            Assert.True(game.IsSuccess(number));
        }

        [Theory]
        [InlineData(30)]
        [InlineData(31)]
        [InlineData(32)]
        [InlineData(33)]
        public void Should_obtain_30_ration(int number)
        {
            var game = new GameContext(2);
            game.TakeRation(21);
            game.TakeRation(31);
            game.TakeRation(22);
            game.TakeRation(32);
            game.TakeRation(33);
            game.TakeRation(34);
            
            Assert.True(game.IsSuccess(number));

            game.TakeRation(number);
            game.TakeRation(35);

            Assert.Equal(30, game.CurrentPlayer.VisibleRation.Value);
        }
    }
}
