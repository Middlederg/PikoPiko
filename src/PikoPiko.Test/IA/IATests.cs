using System;
using Xunit;

namespace PikoPiko.Test
{

    public class IATests
    {
        [Fact]
        public void Should_play_randomly()
        {
            var play = new RandomPlay(21);

            play.Play();

            var result = play.Points;
        }

        [Fact]
        public void Should_play_wormfirst()
        {
            var play = new WormFirstPlay(21);

            play.Play();

            var result = play.Points;
        }

        [Fact]
        public void Should_play_better()
        {
            var play = new WormFirstPlay(21);

            play.Play();

            var result = play.Points;
        }
    }
}
