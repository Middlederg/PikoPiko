using System.Collections.Generic;

namespace PikoPiko.Test
{
    public class TestLogger : ILogger
    {
        public List<string> LogEntry { get; }

        public TestLogger()
        {
            LogEntry = new List<string>();
        }

        public void Info(string message)
        {
            LogEntry.Add(message);
        }
    }
}
