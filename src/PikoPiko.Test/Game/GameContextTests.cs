using Xunit;

namespace PikoPiko.Test
{
    public class GameContextTests
    {
        [Theory]
        [InlineData(14)]
        [InlineData(7)]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        public void Should_be_failed_turn(int number)
        {
            var game = ObjectFactory.TwoPlayerGame;
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
            var game = ObjectFactory.TwoPlayerGame;
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
            var game = ObjectFactory.TwoPlayerGame;
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

        [Fact]
        public void Should_have_no_rations()
        {
            var game = ObjectFactory.TwoPlayerGame;
            game.TakeRation(21);
            game.TakeRation(30);
            game.TakeRation(22);
            game.LoseRation();
            game.TakeRation(23);

            Assert.False(game.CurrentPlayer.HasRations);
        }

        [Fact]
        public void Should_lose_last_ration()
        {
            var game = ObjectFactory.TwoPlayerGame;
            game.TakeRation(21);
            game.TakeRation(30);
            game.TakeRation(22);
            game.TakeRation(32);
            game.LoseRation();
            game.TakeRation(33);

            Assert.Equal(new Ration(21,1), game.CurrentPlayer.VisibleRation);
        }

        [Fact]
        public void Should_remove_ration_on_failing()
        {
            var game = ObjectFactory.TwoPlayerGame;
            game.TakeRation(21);
            game.TakeRation(30);

            game.LoseRation();

            game.TakeRation(21);

            Assert.True(!game.CurrentPlayer.HasRations);

            game.LoseRation();

            Assert.Equal(new Ration(21, 1), game.CurrentPlayer.VisibleRation);
        }
    }
}
