namespace AutoFacDemoLibrary.Utilities;

public class Logger : ILogger
{

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}