using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace HomeWork2._5_Logger
{
    public class Logger
    {
        private List<LogEntry> logEntries = new List<LogEntry>();

        public void Log(LogType logType, string message)
        {
            DateTime logTime = DateTime.Now;
            LogEntry logEntry = new LogEntry { LogTime = logTime, LogType = logType, Message = message };
            logEntries.Add(logEntry);

            string logEntryString = $"{logTime}: {logType}: {message}";
            Console.WriteLine(logEntryString);
        }

        public void WriteToJSONFile(string fileName)
        {
            string json = JsonConvert.SerializeObject(logEntries, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}