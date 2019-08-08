using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PikoPiko.Test
{
    public class ReportTest
    {
        public const int Times = 50;
        private const int easyObjetive = 21;
        private const int mediumObjetive = 28;
        private const int hardObjetive = 34;

        [Fact]
        public void ReportEasyObjetive()
        {
            Report(easyObjetive);
            Report(mediumObjetive);
            Report(hardObjetive);
        }

        private void Report(int objetive)
        {
            var randomPlayEntry = new ReportEntry(nameof(RandomPlay));
            var wormFirstPlayEntry = new ReportEntry(nameof(WormFirstPlay));
            var betterPlayEntry = new ReportEntry(nameof(BetterPlay));
            foreach (var i in Enumerable.Range(0, Times))
            {
                AddToEntry(randomPlayEntry, new RandomPlay(objetive));
                AddToEntry(wormFirstPlayEntry, new WormFirstPlay(objetive));
                AddToEntry(betterPlayEntry, new RandomPlay(objetive));
            }
            return
        }

        private void AddToEntry(ReportEntry reportEntry, BasePlay play)
        {
            play.Play();
            int points = play.Points;
            reportEntry.AddResult(points);
            if (points == 0)
                reportEntry.AddFailure();
        }

        private class ReportEntry
        {
            private List<int> result;
            public void AddResult(int points) => result.Add(points);
            public int Average => (int)Math.Round(result.Average(), 0);

            public string StrategyName { get; }
            
            public int Failure { get; private set; }
            public void AddFailure() => Failure++;

            public ReportEntry(string strategyName)
            {
                StrategyName = strategyName;
                result = new List<int>();
                Failure = 0;
            }

            public string FailPercentage()
            {
                var x = Failure * 100 / Times;
                return $"{x}%";
            }

            public override string ToString()
            {
                return "";
            }
        }
    }
}
