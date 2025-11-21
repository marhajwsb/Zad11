using System;
using System.Collections.Generic;

public sealed class Logger
{
    private static Logger instance = null;
    private static readonly object lockObj = new object();

    private readonly List<string> logs;

    private Logger()
    {
        logs = new List<string>();
    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }
    }

    public void Log(string message)
    {
        logs.Add(message);
    }

    public void ShowLogs()
    {
        Console.WriteLine("Komunikaty:");
        foreach (var msg in logs)
        {
            Console.WriteLine(msg);
        }
    }
}



