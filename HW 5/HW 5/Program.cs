using System;

namespace HW_5;
public sealed class Logger
{
    public static readonly Lazy <Logger> lazyInstance = new Lazy <Logger> (() => new Logger());

    public static Logger Instance => lazyInstance.Value;

    private Logger () {}
    public string Logs { get; private set; }

    public void Log(string logType, string message)
    {
        string log = $"{DateTime.Now}: [{logType}]: {message}";
        Console.WriteLine(log);
        Logs += log + Environment.NewLine;
    }
}