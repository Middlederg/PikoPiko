using System;
using System.Collections.Generic;
using Xunit;

namespace PikoPiko.Test
{
    public class TurnTests
    {
        [Fact]
        public void Should_not_allow_more_players_than_allowed()
        {
            int playerCount = Turn.MaxPlayerNumber + 2;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Turn(playerCount));
        }

        [Fact]
        public void Should_pass_Turn_next()
        {
            var turn = new Turn(5);
            turn.SetTurn(0);

            turn.Next();

            Assert.Equal(1, turn.CurrentTurn);
        }

        [Fact]
        public void Should_pass_Turn_To_0()
        {
            var turn = new Turn(5);
            turn.SetTurn(4);

            turn.Next();

            Assert.Equal(0, turn.CurrentTurn);
        }

        [Fact]
        public void Should_begin_with_correct_turn_value()
        {
            int playerCount = 5;
            var resultList = new List<int>();

            for (int i = 0; i < 50; i++)
			{
                var turn = new Turn(playerCount);
                resultList.Add(turn.CurrentTurn);
                Assert.True(turn.CurrentTurn >= 0);
                Assert.True(turn.CurrentTurn < playerCount);
            }
        }
    }
}
