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
            Assert.DoesNotContain(ration, grill.Rations);
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
    }
}
