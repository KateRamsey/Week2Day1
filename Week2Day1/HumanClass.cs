using System;

public class Human : Organic, ICritters
{
    public Human(string name)
    {
        Name = name;
    }
    public void DisplayName()
    {
        Console.WriteLine($"My Name is {this.Name}");
    }

    public void DisplayGreeting()
    {
        Console.WriteLine("So happy to see you!");
    }

    public string Name { get; set; }
}
