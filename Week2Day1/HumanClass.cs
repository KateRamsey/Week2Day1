using System;

public class Human : IsOrganic, ICritters
{
    public void DisplayName()
    {
        Console.WriteLine($"My Name is {this.Name}");
    }

    public void DisplayGreeting()
    {
        Console.WriteLine("So happy to see you!");
    }
}
