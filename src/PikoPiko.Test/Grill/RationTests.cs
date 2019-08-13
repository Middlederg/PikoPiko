using System.Linq;
using Xunit;

namespace PikoPiko.Test
{
    public class RationTests
    {
        [Theory]
        [InlineData(21, "worms_1")]
        [InlineData(22, "worms_1")]
        [InlineData(23, "worms_1")]
        [InlineData(24, "worms_1")]
        [InlineData(25, "worms_2")]
        [InlineData(26, "worms_2")]
        [InlineData(27, "worms_2")]
        [InlineData(28, "worms_2")]
        [InlineData(29, "worms_3")]
        [InlineData(30, "worms_3")]
        [InlineData(31, "worms_3")]
        [InlineData(32, "worms_3")]
        [InlineData(33, "worms_4")]
        [InlineData(34, "worms_4")]
        [InlineData(35, "worms_4")]
        [InlineData(36, "worms_4")]
        public void Should_give_correct_image(int number, string imagePath)
        {
            var rations = RationFactory.GetRations();

            var result = rations.FirstOrDefault(x => x.Value == number);

            Assert.Equal(imagePath, result.ImagePath);
        }

        [Theory]
        [InlineData(21, "21 (1 worm)")]
        [InlineData(22, "22 (1 worm)")]
        [InlineData(23, "23 (1 worm)")]
        [InlineData(24, "24 (1 worm)")]
        [InlineData(25, "25 (2 worms)")]
        [InlineData(26, "26 (2 worms)")]
        [InlineData(27, "27 (2 worms)")]
        [InlineData(28, "28 (2 worms)")]
        [InlineData(29, "29 (3 worms)")]
        [InlineData(30, "30 (3 worms)")]
        [InlineData(31, "31 (3 worms)")]
        [InlineData(32, "32 (3 worms)")]
        [InlineData(33, "33 (4 worms)")]
        [InlineData(34, "34 (4 worms)")]
        [InlineData(35, "35 (4 worms)")]
        [InlineData(36, "36 (4 worms)")]
        public void Should_give_correct_ration_name(int number, string name)
        {
            var rations = RationFactory.GetRations();

            var result = rations.FirstOrDefault(x => x.Value == number);

            Assert.Equal(name, result.ToString());
        }

        [Fact]
        public void Should_generate_grill()
        {
            var rations = RationFactory.GetRations().ToList();

            var minRation = rations.FirstOrDefault(ration => ration.Value == rations.Min(x => x.Value));
            var maxRation = rations.FirstOrDefault(ration => ration.Value == rations.Max(x => x.Value));

            Assert.Equal(new Ration(21, 1), minRation);
            Assert.Equal(new Ration(36, 4), maxRation);
            Assert.True(rations.Count == RationFactory.RationCount);

            Assert.Contains(new Ration(21, 1), rations);
            Assert.Contains(new Ration(22, 1), rations);
            Assert.Contains(new Ration(23, 1), rations);
            Assert.Contains(new Ration(24, 1), rations);
            Assert.Contains(new Ration(25, 2), rations);
            Assert.Contains(new Ration(26, 2), rations);
            Assert.Contains(new Ration(27, 2), rations);
            Assert.Contains(new Ration(28, 2), rations);
            Assert.Contains(new Ration(29, 3), rations);
            Assert.Contains(new Ration(30, 3), rations);
            Assert.Contains(new Ration(31, 3), rations);
            Assert.Contains(new Ration(32, 3), rations);
            Assert.Contains(new Ration(33, 4), rations);
            Assert.Contains(new Ration(34, 4), rations);
            Assert.Contains(new Ration(35, 4), rations);
            Assert.Contains(new Ration(36, 4), rations);
        }
    }
}
