using System;

public class Robot: ICritters
{
    public Robot(string name)
    {
        this.Running = false;
        this.IsTerminator = true;
        this.Name = name;
    }
    public bool Running;
    public bool IsTerminator;

    public string Name { get; set; }

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

    public void DisplayName()
    {
        Console.WriteLine($"My Name is {this.Name}");
    }

    public void DisplayGreeting()
    {
        Console.WriteLine("Greetings, I am a robot");
    }

    public bool IsASleep()
    {
        return !Running;
    }
}
