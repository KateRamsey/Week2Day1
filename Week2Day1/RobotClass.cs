using System;

public class Robot
{
    public Robot()
    {
        this.Running = false;
        this.IsTerminator = true;
    }
    public bool Running;
    public bool IsTerminator;

    public void StartUp()
    {
        Console.WriteLine("Started...");
        this.Running = true;
    }

    public void ShutDown()
    {
        Console.WriteLine("Shutdown...");
        this.Running = false;
    }

}
