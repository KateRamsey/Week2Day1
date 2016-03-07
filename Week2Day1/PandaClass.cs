using System;

public class Panda : IsOrganic, ICritters
{
    public void DisplayName()
    {
        Console.WriteLine($"My Name is {this.Name}");
    }

    public void DisplayGreeting()
    {
        Console.WriteLine("Nom Nom, hello, I am eating bamboo");
    }

}
