using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace PikoPiko.Test
{
    public class ReportTest
    {
        public const int Times = 250;
        private const int easyObjetive = 21;
        private const int mediumObjetive = 28;
        private const int hardObjetive = 34;

        [Fact]
        public void Should_write_complete_report()
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
            var cleverPlayEntry = new ReportEntry(nameof(CleverPlay));
            foreach (var i in Enumerable.Range(0, Times))
            {
                AddToEntry(randomPlayEntry, new RandomPlay(objetive));
                AddToEntry(wormFirstPlayEntry, new WormFirstPlay(objetive));
                AddToEntry(betterPlayEntry, new BetterPlay(objetive));
                AddToEntry(cleverPlayEntry, new CleverPlay(objetive));
            }

            Debug.WriteLine($"Objetive: {objetive}");
            Debug.WriteLine(randomPlayEntry.ToString());
            Debug.WriteLine(wormFirstPlayEntry.ToString());
            Debug.WriteLine(betterPlayEntry.ToString());
            Debug.WriteLine(cleverPlayEntry.ToString());
            Debug.WriteLine("");
        }

        private void AddToEntry(ReportEntry reportEntry, BasePlay play)
        {
            play.Play();
            int points = play.Points;
            if (points == 0)
                reportEntry.AddFailure();
            else
                reportEntry.AddResult(points);
        }

        private class ReportEntry
        {
            private readonly List<int> result;
            public void AddResult(int points) => result.Add(points);
            public int Average
            {
                get
                {
                    if (!result.Any())
                        return 0;

                    return (int)Math.Round(result.Average(), 0);
                }
            }

            public string StrategyName { get; }
            
            public int Failure { get; private set; }
            public void AddFailure() => Failure++;

            public ReportEntry(string strategyName)
            {
                StrategyName = strategyName;
                result = new List<int>();
                Failure = 0;
            }

            public string SuccessPercentage()
            {
                var x = 100 - (Failure * 100 / Times);
                return $"{x}%";
            }

            public override string ToString() => $"Name: {StrategyName}. Avg: {Average}, Success: {SuccessPercentage()}";
            
        }
    }
}
