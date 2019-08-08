using Xunit;

namespace PikoPiko.Test
{
    public class PlayerTests
    {
        [Fact]
        public void Should_not_have_rations_when_created()
        {
            var player = new Player();

            Assert.False(player.HasRations);
            Assert.Null(player.VisibleRation);
        }

        [Fact]
        public void Last_got_ration_is_visible()
        {
            var player = new Player();
            var ration = new Ration(2, 2);

            player.AddRation(new Ration(1, 1));
            player.AddRation(ration);

            Assert.True(player.HasRations);
            Assert.Equal(ration, player.VisibleRation);
        }

        [Fact]
        public void Should_remove_last_ration()
        {
            var player = new Player();
            var ration1 = new Ration(1, 1);
            var ration2 = new Ration(2, 1);
            var ration3 = new Ration(3, 1);
            var ration4 = new Ration(4, 1);

            player.AddRation(ration1);
            player.AddRation(ration2);
            player.AddRation(ration3);
            player.AddRation(ration4);
            player.Remove();

            Assert.Equal(ration3, player.VisibleRation);
            Assert.True(player.HasRations);
        }

        [Fact]
        public void Should_calculate_points()
        {
            var player = new Player();

            player.AddRation(new Ration(21, 1));
            player.AddRation(new Ration(30, 3));

            Assert.True(player.HasRations);
            Assert.Equal(4, player.Worms());
            Assert.Equal(30, player.MaxValue());
        }

        [Fact]
        public void Should_have_0_points()
        {
            var player = new Player();

            player.AddRation(new Ration(21, 1));
            player.Remove();

            Assert.False(player.HasRations);
            Assert.Equal(0, player.Worms());
            Assert.Equal(0, player.MaxValue());
        }
    }
}
