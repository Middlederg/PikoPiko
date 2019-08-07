using Xunit;

namespace PikoPiko.Test
{
    public class PlayersInteractionsTest
    {
        [Fact]
        public void Should_find_other_players_ration()
        {
            var players = new Players(2);
            players.CurrentPlayer.AddRation(new Ration(21, 1));
            players.CurrentPlayer.AddRation(new Ration(22, 1));
            players.Next();

            var isRationFound = players.OtherPlayerHasVisibleRation(22);

            Assert.True(isRationFound);
        }

        [Fact]
        public void Should_not_find_other_players_ration()
        {
            var players = new Players(2);
            players.CurrentPlayer.AddRation(new Ration(21, 1));
            players.CurrentPlayer.AddRation(new Ration(22, 1));
            players.Next();

            var isRationFound = players.OtherPlayerHasVisibleRation(21);

            Assert.False(isRationFound);
        }

        [Fact]
        public void Should_remove_ration_form_other_player()
        {
            var players = new Players(2);
            var ration = new Ration(22, 1);
            players.CurrentPlayer.AddRation(new Ration(21, 1));
            players.CurrentPlayer.AddRation(ration);
            players.Next();

            players.RemoveRationFromOtherPlayer(22);

            Assert.Equal(ration, players.CurrentPlayer.VisibleRation);
        }

        [Fact]
        public void Should_throw_exception_removing_hidden_ration()
        {
            var players = new Players(2);
            var ration = new Ration(22, 1);
            players.CurrentPlayer.AddRation(new Ration(21, 1));
            players.CurrentPlayer.AddRation(ration);
            players.Next();

            Assert.Throws<RationNotFoundException>(() => players.RemoveRationFromOtherPlayer(21));
        }
    }
}
