using System;

public class Panda : Organic, ICritters
{
    public Panda(string name)
    {
        Name = name;
    }
    public void DisplayName()
    {
        Console.WriteLine($"My Name is {this.Name}");
    }

    public void DisplayGreeting()
    {
        Console.WriteLine("Nom Nom, hello, I am eating bamboo");
    }
    public string Name { get; set; }

}
