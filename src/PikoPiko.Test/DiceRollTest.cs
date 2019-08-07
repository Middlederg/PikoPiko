using System.Linq;
using Xunit;

namespace PikoPiko.Test
{
    public class DiceRollTest
    {
        [Fact]
        public void Should_give_between_0_and_8_worms()
        {
            var roll = new DiceRoll();

            var results = roll.GetResults(ResultFactory.Worm);

            Assert.True(results.Count() >= 0);
            Assert.True(results.Count() <= DiceRoll.StartingDiceCount);
        }

        [Fact]
        public void Parts_of_roll_should_be_in_the_roll()
        {
            var roll = new DiceRoll();

            var results = roll.GetAllResults();

            foreach (var result in results)
            {
                var part = roll.GetResults(result).ToList();
                Assert.True(part.Any());
            }
        }

        [Fact]
        public void Should_have_all_part()
        {
            var roll = new DiceRoll();

            var results = roll.GetAllResults();

            foreach (var result in results)
            {
                var hasResult = roll.Has(result);
                Assert.True(hasResult);
            }
        }

        [Fact]
        public void Higest_shouls_be_greater_than_0()
        {
            var roll = new DiceRoll();

            var entry = roll.Higest();

            Assert.NotNull(entry);
            Assert.True(entry.Points() > 0);
        }
    }
}
