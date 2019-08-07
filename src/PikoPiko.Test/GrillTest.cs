using System;
using System.Linq;
using Xunit;

namespace PikoPiko.Test
{
    public class GrillTest
    {
        [Theory]
        [InlineData(21)]
        [InlineData(25)]
        [InlineData(34)]
        public void Should_be_exact_ration_in_grill(int number)
        {
            var grill = new Grill();

            var avaliable = grill.IsAvaliable(number);
            var ration = grill.TakeRation(number);

            Assert.True(avaliable);
            Assert.Equal(RationFactory.GetRations().First(x => x.Value == number), ration);
        }

        [Theory]
        [InlineData(21)]
        [InlineData(25)]
        [InlineData(34)]
        public void When_ration_is_taken_should_be_removed_from_grill(int number)
        {
            var grill = new Grill();

            var avaliableBefore = grill.IsAvaliable(number);
            var ration = grill.TakeRation(number);
            var avaliableAfter = grill.IsAvaliable(number);

            Assert.True(avaliableBefore);
            Assert.False(avaliableAfter);
        }

        [Fact]
        public void Should_not_be_any_ration()
        {
            int number = 21;
            var grill = new Grill();
            grill.TakeRation(number);

            var avaliable = grill.IsAvaliable(number);

            Assert.False(avaliable);
            Assert.Throws<RationNotFoundException>(() => grill.TakeRation(number));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(17)]
        [InlineData(18)]
        [InlineData(19)]
        [InlineData(20)]
        public void Should_not_be_any_ration_when_number_is_too_small(int number)
        {
            var grill = new Grill();

            var avaliable = grill.IsAvaliable(number);

            Assert.False(avaliable);
            Assert.Throws<RationNotFoundException>(() => grill.TakeRation(number));
        }

        [Fact]
        public void Should_not_turn_down_highest_ration()
        {
            var grill = new Grill();
            var ration36 = grill.TakeRation(36);

            var isLower = grill.IsLowerThanHighestRation(ration36);

            Assert.False(isLower);
        }

        [Fact]
        public void Should_turn_down_highest_ration()
        {
            var grill = new Grill();
            var ration35 = grill.TakeRation(35);

            var isLower = grill.IsLowerThanHighestRation(ration35);
            grill.TurnDownHighestRation();
            var isAvaliable = grill.IsAvaliable(36);

            Assert.True(isLower);
            Assert.False(isAvaliable);
        }
    }
}
