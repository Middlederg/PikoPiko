using System;
using Xunit;

namespace PikoPiko.Test
{
    public class DicesTests
    {
        [Fact]
        public void Is_real_worm()
        {
            var result = new WormResult();

            Assert.Equal(5, result.Value);
            Assert.True(result.IsWorm);
        }

        [Fact]
        public void Is_not_a_worm_result()
        {
            var result = new Four();

            Assert.Equal(4, result.Value);
            Assert.False(result.IsWorm);
        }

        [Fact]
        public void Can_generate_dice_result()
        {
            var result = ResultFactory.GetRandomResult();

            Assert.IsAssignableFrom<IResult>(result);
        }

        [Theory]
        [InlineData(1, "result-1")]
        [InlineData(2, "result-2")]
        [InlineData(3, "result-3")]
        [InlineData(4, "result-4")]
        [InlineData(5, "result-5")]
        [InlineData(6, "worm")]
        public void Should_give_correct_image(int number, string imagePath)
        {
            var result = ResultFactory.GetResult(number);

            Assert.Equal(imagePath, result.ImagePath);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "3")]
        [InlineData(4, "4")]
        [InlineData(5, "5")]
        [InlineData(6, "Worm (5)")]
        public void Should_give_correct_dice_name(int number, string name)
        {
            var result = ResultFactory.GetResult(number);

            Assert.Equal(name, result.ToString());
        }
    }
}
